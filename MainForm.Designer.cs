
namespace EduGit {
	partial class MainForm {
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.OpenFileDialog openEditorDialog;
		private System.Windows.Forms.Button buttonEditor;
		private System.Windows.Forms.RichTextBox textBoxLog;
		private System.Windows.Forms.Button buttonDir;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Label labelEditor;
		private System.Windows.Forms.TextBox textBoxTask;
		private System.Windows.Forms.Label labelDir;
		private System.Windows.Forms.TextBox textBoxCommit;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.FolderBrowserDialog selectFolderDialog;
		private System.Windows.Forms.Label label1;
		
		protected override void Dispose(bool disposing) {
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.openEditorDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonEditor = new System.Windows.Forms.Button();
			this.buttonDir = new System.Windows.Forms.Button();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.labelEditor = new System.Windows.Forms.Label();
			this.textBoxTask = new System.Windows.Forms.TextBox();
			this.textBoxCommit = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.selectFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.labelDir = new System.Windows.Forms.Label();
			this.textBoxLog = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// openEditorDialog
			// 
			this.openEditorDialog.FileName = "openFileDialog1";
			this.openEditorDialog.Filter = "Programy|*.exe";
			// 
			// buttonEditor
			// 
			this.buttonEditor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonEditor.Location = new System.Drawing.Point(254, 40);
			this.buttonEditor.Margin = new System.Windows.Forms.Padding(4);
			this.buttonEditor.Name = "buttonEditor";
			this.buttonEditor.Size = new System.Drawing.Size(137, 25);
			this.buttonEditor.TabIndex = 6;
			this.buttonEditor.Text = "Textový editor...";
			this.buttonEditor.UseVisualStyleBackColor = true;
			this.buttonEditor.Click += new System.EventHandler(this.ButtonEditorClick);
			// 
			// buttonDir
			// 
			this.buttonDir.Location = new System.Drawing.Point(254, 11);
			this.buttonDir.Name = "buttonDir";
			this.buttonDir.Size = new System.Drawing.Size(137, 25);
			this.buttonDir.TabIndex = 5;
			this.buttonDir.Text = "Adresář projektů...";
			this.buttonDir.UseVisualStyleBackColor = true;
			this.buttonDir.Click += new System.EventHandler(this.ButtonDirClick);
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(132, 11);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(67, 25);
			this.buttonOpen.TabIndex = 2;
			this.buttonOpen.Text = "Otevři";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.ButtonOpenClick);
			// 
			// labelEditor
			// 
			this.labelEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelEditor.Location = new System.Drawing.Point(398, 41);
			this.labelEditor.Name = "labelEditor";
			this.labelEditor.Size = new System.Drawing.Size(163, 23);
			this.labelEditor.TabIndex = 0;
			this.labelEditor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxTask
			// 
			this.textBoxTask.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxTask.Location = new System.Drawing.Point(11, 12);
			this.textBoxTask.Name = "textBoxTask";
			this.textBoxTask.Size = new System.Drawing.Size(115, 23);
			this.textBoxTask.TabIndex = 1;
			// 
			// textBoxCommit
			// 
			this.textBoxCommit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxCommit.Location = new System.Drawing.Point(11, 41);
			this.textBoxCommit.Name = "textBoxCommit";
			this.textBoxCommit.Size = new System.Drawing.Size(115, 23);
			this.textBoxCommit.TabIndex = 3;
			this.textBoxCommit.Text = "úkol opraven";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(132, 40);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(67, 25);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Ulož";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// labelDir
			// 
			this.labelDir.AutoEllipsis = true;
			this.labelDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDir.Location = new System.Drawing.Point(398, 12);
			this.labelDir.Name = "labelDir";
			this.labelDir.Size = new System.Drawing.Size(163, 23);
			this.labelDir.TabIndex = 0;
			this.labelDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxLog
			// 
			this.textBoxLog.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxLog.Location = new System.Drawing.Point(12, 71);
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.Size = new System.Drawing.Size(549, 378);
			this.textBoxLog.TabIndex = 0;
			this.textBoxLog.TabStop = false;
			this.textBoxLog.Text = resources.GetString("textBoxLog.Text");
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(11, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(551, 380);
			this.label1.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 461);
			this.Controls.Add(this.textBoxLog);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelDir);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxCommit);
			this.Controls.Add(this.textBoxTask);
			this.Controls.Add(this.labelEditor);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.buttonDir);
			this.Controls.Add(this.buttonEditor);
			this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "EduGit - ŠkolaZdola";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
