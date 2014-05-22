using System;
using System.IO;
using System.Windows.Forms;

namespace Cselian.Sublime
{
	public partial class Main : Form
	{
		private string[] Lines;
		private int LineIndex;
		private int secsLeft = 10;

		private const string MessagesFile = "sublime-messages.txt";
		private const string IntervalFile = "sublime-interval.txt";

		public Main()
		{
			InitializeComponent();

			if (File.Exists(MessagesFile)) txtLines.Text = File.ReadAllText(MessagesFile);
			Lines = txtLines.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			
			popup = new Popup();

			if (File.Exists(IntervalFile)) secsLeft = int.Parse(File.ReadAllText(IntervalFile));
			txtInterval.Text = secsLeft.ToString();
			timer = new System.Timers.Timer(secsLeft * 1000);
			timer.Enabled = true;
			timer.Elapsed += timer_Elapsed;
			timer_Elapsed(null, null);
		}

		// Forms.Timer doesnt tick when its minimized
		private System.Timers.Timer timer;
		Popup popup; // lets reuse the same form

		private void txtInterval_TextChanged(object sender, EventArgs e)
		{
			if (timer == null) return;
			secsLeft = int.Parse(txtInterval.Text);
			timer.Interval = secsLeft * 1000;
			File.WriteAllText(IntervalFile, txtInterval.Text);
		}

		private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			if (chkPause.Checked) return;

			var line = Lines[LineIndex];

			popup.SetText(line);

			LineIndex += 1;
			if (LineIndex == Lines.Length)
				LineIndex = 0;

			secsLeft = (int)Math.Ceiling(timer.Interval / 1000);
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			Lines = txtLines.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			File.WriteAllText(MessagesFile, txtLines.Text);
		}

		private void tmrSecs_Tick(object sender, EventArgs e)
		{
			if (chkPause.Checked) return;
			secsLeft -= 1;
			lblSecsLeft.Text = secsLeft.ToString() + " remaining";
		}
	}
}
