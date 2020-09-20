using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace EduGit {
	public partial class MainForm : Form {
		Properties.EduSettings Data = Properties.EduSettings.Default;
	    Encoding CP1250 = Encoding.GetEncoding(1250);
	    List<string> Dirs = new List<string>();
		
		public MainForm()
		{
			Data.Dir = @"D:\Projects\Git\example";
			Data.Editor = @"D:\ProgramsWin\PSPad\PSPad.exe";
			InitializeComponent();
			labelDir.Text = Data.Dir.Trim();
			labelEditor.Text = Path.GetFileNameWithoutExtension(Data.Editor.Trim());
		}
	    
	    string ConvertCP(string input, Encoding from, Encoding to)
	    {
		    byte[] bytes = from.GetBytes(input);
		    return to.GetString(bytes);	    	
	    }

	    string scriptArgs;
		void RunScript(string command, string args="", string dir="", bool asyn=false)
		{
			scriptArgs = args;
			
			var cfg = new ProcessStartInfo(command, args);
		    cfg.CreateNoWindow = true;
		    cfg.RedirectStandardInput = true;
		    cfg.RedirectStandardOutput = true;
		    cfg.RedirectStandardError = true;
		    cfg.UseShellExecute = false;
		    cfg.WorkingDirectory = dir;
			
			var cmd = new Process();
			cmd.EnableRaisingEvents = true;
			cmd.StartInfo = cfg;
			if(asyn) {
				cmd.OutputDataReceived += AsynScriptOutput;
				cmd.ErrorDataReceived += AsynScriptOutput;
			}
				
		    cmd.Start();
		    if(asyn) {
			    cmd.BeginErrorReadLine();
			    cmd.BeginOutputReadLine();
		    }
		    else {
			    string result = "";
			    result+= cmd.StandardOutput.ReadToEnd();
			    result+= cmd.StandardError.ReadToEnd();
				result = ConvertCP(result, CP1250, Encoding.UTF8).Trim('\r','\n');
				result = ProcessText(result, args, dir);
			    if(result!="") textBoxLog.AppendML(result);
			    cmd.WaitForExit();
		    }
		}
		
		void AsynScriptOutput(object sender, DataReceivedEventArgs e)
		{
			if(e.Data==null) return;
			string output = ConvertCP(e.Data, CP1250, Encoding.UTF8);
			LogFromAction(output);
		}
		void LogFromAction(string data) {
			if(InvokeRequired) {
				var action = new Action<string>(LogFromAction);
				var args = new object[] {data};
				Invoke(action, args);
	            return;
			}
			if(data==null) return;
			// data availale here
		}

		string ProcessText(string input, string args, string dir="") {
			if(args=="remote update") return "";
			if(args=="status -uno") {
				if(input.Contains("ahead")) RunScript("git", "push", dir, true);
				if(input.Contains("ahead") || input.Contains("up to date")) return "<Orange>žádné novinky<>";
				if(input.Contains("behind")) {
					RunScript("git", "pull", dir);
					string file = dir+"\\"+textBoxTask.Text.Trim();
					Process.Start(Data.Editor, String.Format("\"{0}\"", file));
					Dirs.Add(dir);
					return "<Green>nová reakce, otevírám<>";
				}
				else if(input.Contains("diverged")) return "<Red>konflikt, nutno ručně sloučit<>";
			}
			return input;
		}
		
	    void ButtonEditorClick(object sender, EventArgs e)
		{
			if(openEditorDialog.ShowDialog()==DialogResult.OK) {
	    		Data.Editor = openEditorDialog.FileName;
	    		labelEditor.Text = Path.GetFileNameWithoutExtension(Data.Editor.Trim());
				Data.Save();
			}
		}
		
		void ButtonDirClick(object sender, EventArgs e)
		{
			if(selectFolderDialog.ShowDialog()==DialogResult.OK) {
				Data.Dir = selectFolderDialog.SelectedPath;
				labelDir.Text = Data.Dir.Trim();
				Data.Save();
			}
		}

		void ButtonOpenClick(object sender, EventArgs e)
		{
			if(String.IsNullOrEmpty(Data.Editor)) {
				MessageBox.Show("Vyber editor, ve kterém se mají úkoly otevřít.");
				return;
			}
			if(String.IsNullOrEmpty(Data.Dir)) {
				MessageBox.Show("Vyber adresář s git projekty.");
				return;
			}
			if(String.IsNullOrEmpty(textBoxTask.Text.Trim())) {
				MessageBox.Show("Vyber úkol v git projektech.");
				return;
			}
			textBoxLog.Text = "";
			Dirs.Clear();
			textBoxLog.AppendML("<bold>Otevírání souboru "+textBoxTask.Text.Trim()+"<>");
			foreach(string dir in Directory.GetDirectories(Data.Dir)) {
				textBoxLog.AppendText(Path.GetFileName(dir)+" ... ");
				if(!Directory.Exists(dir+"\\.git")) {
					textBoxLog.AppendML("<Red>Chybí repozitář <Black>Použij 'git clone' nebo odstraň<>");
					continue;
				}
				RunScript("git", "remote update", dir);
				RunScript("git", "status -uno", dir);
			}
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			foreach(string dir in Dirs) {
				RunScript("git", "add .", dir);
				string msg = textBoxCommit.Text.Trim();
				RunScript("git", String.Format("commit -m \"{0}\"", msg));
				RunScript("git", "push", dir);
			}
		}

	}
}
