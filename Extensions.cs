using System;
using System.Windows.Forms;
using System.Drawing;

namespace EduGit {
	public static class Extensions
	{
	    public static void AppendText(this RichTextBox box, string text, Color? color=null, FontStyle style=FontStyle.Regular)
	    {
	        box.SelectionStart = box.TextLength;
	        box.SelectionLength = 0;
	
	        Color realColor = color==null ? Color.Black : (Color)color;
	        box.SelectionColor = realColor;
	        box.SelectionFont = new Font("Calibri", 12F, style, GraphicsUnit.Point, 238);

	        box.AppendText(text);
	        box.SelectionColor = box.ForeColor;
	    }
	    public static void AppendML(this RichTextBox box, string text)
	    {
	    	if(String.IsNullOrEmpty(text)) return;
	    	foreach(string part in text.Split('<')) {
	    		if(part==">") {
	    			box.AppendText(Environment.NewLine);
	    			continue;
	    		}
	    		string[] sub = part.Split('>');
	    		if(sub.Length==1) box.AppendText(sub[0]);
	    		else {
		    		bool bold = sub[0].StartsWith("bold", StringComparison.CurrentCulture);
		    		if(bold) sub[0] = sub[0].Substring(4);
		    		Color color = sub[0]=="" ? Color.Black : Color.FromName(sub[0]);
		    		FontStyle style = bold ? FontStyle.Bold : FontStyle.Regular;
		    		box.AppendText(sub[1], color, style);
	    		}
	    	}
	    }
	}
}