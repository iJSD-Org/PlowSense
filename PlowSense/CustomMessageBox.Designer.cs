namespace PlowSense
{
	partial class CustomMessageBox
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.continueButton = new Guna.UI2.WinForms.Guna2Button();
            this.gifAnimationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox.ErrorImage = global::PlowSense.Properties.Resources.Check;
            this.iconPictureBox.Image = global::PlowSense.Properties.Resources.Cross;
            this.iconPictureBox.Location = new System.Drawing.Point(189, 15);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(145, 128);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(73, 146);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(371, 28);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "ERROR";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descLabel
            // 
            this.descLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descLabel.Location = new System.Drawing.Point(75, 172);
            this.descLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(369, 65);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "System cannot find the file specified.";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // continueButton
            // 
            this.continueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.continueButton.Animated = true;
            this.continueButton.AutoRoundedCorners = true;
            this.continueButton.BorderRadius = 17;
            this.continueButton.CheckedState.Parent = this.continueButton;
            this.continueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueButton.CustomImages.Parent = this.continueButton;
            this.continueButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(24)))));
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.HoverState.Parent = this.continueButton;
            this.continueButton.Location = new System.Drawing.Point(159, 228);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.continueButton.Name = "continueButton";
            this.continueButton.ShadowDecoration.Parent = this.continueButton;
            this.continueButton.Size = new System.Drawing.Size(200, 37);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Continue";
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // gifAnimationTimer
            // 
            this.gifAnimationTimer.Enabled = true;
            this.gifAnimationTimer.Interval = 3000;
            this.gifAnimationTimer.Tick += new System.EventHandler(this.gifAnimationTimer_Tick);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(517, 279);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.iconPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomMessageBox";
            this.ShowInTaskbar = false;
            this.Text = "CustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.PictureBox iconPictureBox;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private Guna.UI2.WinForms.Guna2Button continueButton;
		private System.Windows.Forms.Label descLabel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Timer gifAnimationTimer;
	}
}