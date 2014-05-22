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
			this.txtLines = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.chkPause = new System.Windows.Forms.CheckBox();
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
			this.txtLines.Size = new System.Drawing.Size(389, 209);
			this.txtLines.TabIndex = 0;
			this.txtLines.Text = "I am calm and composed at all times\r\nI am fit and fine in mind and body\r\nThe powe" +
    "r within me is restoring me to good health\r\nI have the will power to achieve any" +
    "thing I want";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(326, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
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
			this.chkPause.TabIndex = 2;
			this.chkPause.Text = "&Pause";
			this.chkPause.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 262);
			this.Controls.Add(this.chkPause);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtLines);
			this.Name = "Main";
			this.Text = "Subliminal Messages";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLines;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox chkPause;
	}
}

