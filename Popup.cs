using System;
using System.Windows.Forms;

namespace Cselian.Sublime
{
	public partial class Popup : Form
	{
		public Popup()
		{
			InitializeComponent();
			tmrTick.Interval = 100;
		}

		// timer.Elapsed is on a different thread, so is forms timer
		private string text;

		public void SetText(string text)
		{
			this.text = text;
		}

		private void tmrTick_Tick(object sender, EventArgs e)
		{
			if (text != null)
			{
				lblMsg.Text = text;
				Width = lblMsg.Width + 2 * lblMsg.Left;
				Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
				text = null;
				Show();
			}
			else if (Visible)
			{
				Hide();
			}
		}
	}
}
