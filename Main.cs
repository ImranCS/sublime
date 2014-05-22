using System;
using System.IO;
using System.Windows.Forms;

namespace Cselian.Sublime
{
	public partial class Main : Form
	{
		private string[] Lines;
		private int LineIndex;

		public Main()
		{
			InitializeComponent();

			if (File.Exists("lines.txt")) txtLines.Text = File.ReadAllText("lines.txt");
			Lines = txtLines.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			popup = new Popup();
			timer = new System.Timers.Timer(10000);
			timer.Enabled = true;
			timer.Elapsed += timer_Elapsed;
			timer_Elapsed(null, null);
		}

		// Forms.Timer doesnt tick when its minimized
		private System.Timers.Timer timer;
		Popup popup; // lets reuse the same form

		private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			if (chkPause.Checked) return;

			var line = Lines[LineIndex];

			popup.SetText(line);

			LineIndex += 1;
			if (LineIndex == Lines.Length)
				LineIndex = 0;
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			Lines = txtLines.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			File.WriteAllText("lines.txt", txtLines.Text);
		}
	}
}
