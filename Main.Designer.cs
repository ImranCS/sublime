namespace Cselian.Sublime
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.txtLines = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.chkPause = new System.Windows.Forms.CheckBox();
			this.lblInterval = new System.Windows.Forms.Label();
			this.txtInterval = new System.Windows.Forms.TextBox();
			this.tmrSecs = new System.Windows.Forms.Timer(this.components);
			this.lblSecsLeft = new System.Windows.Forms.Label();
			this.txtTimeOn = new System.Windows.Forms.TextBox();
			this.lblTimeOn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtLines
			// 
			this.txtLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLines.Location = new System.Drawing.Point(12, 41);
			this.txtLines.Multiline = true;
			this.txtLines.Name = "txtLines";
			this.txtLines.Size = new System.Drawing.Size(310, 109);
			this.txtLines.TabIndex = 4;
			this.txtLines.Text = "I am calm and composed at all times\r\nI am fit and fine in mind and body\r\nThe powe" +
    "r within me is restoring me to good health\r\nI have the will power to achieve any" +
    "thing I want";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(278, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(44, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// chkPause
			// 
			this.chkPause.AutoSize = true;
			this.chkPause.Location = new System.Drawing.Point(12, 16);
			this.chkPause.Name = "chkPause";
			this.chkPause.Size = new System.Drawing.Size(56, 17);
			this.chkPause.TabIndex = 0;
			this.chkPause.Text = "&Pause";
			this.chkPause.UseVisualStyleBackColor = true;
			// 
			// lblInterval
			// 
			this.lblInterval.AutoSize = true;
			this.lblInterval.Location = new System.Drawing.Point(105, 17);
			this.lblInterval.Name = "lblInterval";
			this.lblInterval.Size = new System.Drawing.Size(29, 13);
			this.lblInterval.TabIndex = 1;
			this.lblInterval.Text = "secs";
			// 
			// txtInterval
			// 
			this.txtInterval.Location = new System.Drawing.Point(65, 13);
			this.txtInterval.Name = "txtInterval";
			this.txtInterval.Size = new System.Drawing.Size(37, 20);
			this.txtInterval.TabIndex = 2;
			this.txtInterval.Text = "10";
			this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
			// 
			// tmrSecs
			// 
			this.tmrSecs.Enabled = true;
			this.tmrSecs.Interval = 1000;
			this.tmrSecs.Tick += new System.EventHandler(this.tmrSecs_Tick);
			// 
			// lblSecsLeft
			// 
			this.lblSecsLeft.AutoSize = true;
			this.lblSecsLeft.Location = new System.Drawing.Point(136, 17);
			this.lblSecsLeft.Name = "lblSecsLeft";
			this.lblSecsLeft.Size = new System.Drawing.Size(36, 13);
			this.lblSecsLeft.TabIndex = 1;
			this.lblSecsLeft.Text = "10 left";
			// 
			// txtTimeOn
			// 
			this.txtTimeOn.Location = new System.Drawing.Point(187, 12);
			this.txtTimeOn.Name = "txtTimeOn";
			this.txtTimeOn.Size = new System.Drawing.Size(37, 20);
			this.txtTimeOn.TabIndex = 6;
			this.txtTimeOn.Text = "100";
			this.txtTimeOn.TextChanged += new System.EventHandler(this.txtTimeOn_TextChanged);
			// 
			// lblTimeOn
			// 
			this.lblTimeOn.AutoSize = true;
			this.lblTimeOn.Location = new System.Drawing.Point(227, 16);
			this.lblTimeOn.Name = "lblTimeOn";
			this.lblTimeOn.Size = new System.Drawing.Size(35, 13);
			this.lblTimeOn.TabIndex = 5;
			this.lblTimeOn.Text = "ms on";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 162);
			this.Controls.Add(this.txtTimeOn);
			this.Controls.Add(this.lblTimeOn);
			this.Controls.Add(this.txtInterval);
			this.Controls.Add(this.lblSecsLeft);
			this.Controls.Add(this.lblInterval);
			this.Controls.Add(this.chkPause);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtLines);
			this.MinimumSize = new System.Drawing.Size(350, 200);
			this.Name = "Main";
			this.Text = "Subliminal Messages / Cselian.com";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLines;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox chkPause;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.TextBox txtInterval;
		private System.Windows.Forms.Timer tmrSecs;
		private System.Windows.Forms.Label lblSecsLeft;
		private System.Windows.Forms.TextBox txtTimeOn;
		private System.Windows.Forms.Label lblTimeOn;
	}
}

