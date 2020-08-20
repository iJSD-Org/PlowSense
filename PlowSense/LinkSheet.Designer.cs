namespace PlowSense
{
	partial class LinkSheet
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
			this.txtBoxSheetID = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.okBtn = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.exitImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
			this.formShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 13;
			this.guna2Elipse1.TargetControl = this;
			// 
			// txtBoxSheetID
			// 
			this.txtBoxSheetID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtBoxSheetID.Animated = true;
			this.txtBoxSheetID.AutoRoundedCorners = true;
			this.txtBoxSheetID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
			this.txtBoxSheetID.BorderRadius = 13;
			this.txtBoxSheetID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBoxSheetID.DefaultText = "";
			this.txtBoxSheetID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtBoxSheetID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtBoxSheetID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBoxSheetID.DisabledState.Parent = this.txtBoxSheetID;
			this.txtBoxSheetID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBoxSheetID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
			this.txtBoxSheetID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBoxSheetID.FocusedState.Parent = this.txtBoxSheetID;
			this.txtBoxSheetID.Font = new System.Drawing.Font("Proxima Soft", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxSheetID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBoxSheetID.HoverState.Parent = this.txtBoxSheetID;
			this.txtBoxSheetID.Location = new System.Drawing.Point(9, 164);
			this.txtBoxSheetID.Margin = new System.Windows.Forms.Padding(2);
			this.txtBoxSheetID.Name = "txtBoxSheetID";
			this.txtBoxSheetID.PasswordChar = '\0';
			this.txtBoxSheetID.PlaceholderText = "sheetID";
			this.txtBoxSheetID.SelectedText = "";
			this.txtBoxSheetID.ShadowDecoration.Parent = this.txtBoxSheetID;
			this.txtBoxSheetID.Size = new System.Drawing.Size(252, 29);
			this.txtBoxSheetID.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Proxima Soft Light", 17F);
			this.label1.Location = new System.Drawing.Point(2, 136);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(267, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Please enter your sheetID";
			// 
			// okBtn
			// 
			this.okBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.okBtn.Animated = true;
			this.okBtn.AutoRoundedCorners = true;
			this.okBtn.BorderRadius = 15;
			this.okBtn.CheckedState.Parent = this.okBtn;
			this.okBtn.CustomImages.Parent = this.okBtn;
			this.okBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(81)))));
			this.okBtn.Font = new System.Drawing.Font("Proxima Soft", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okBtn.ForeColor = System.Drawing.Color.White;
			this.okBtn.HoverState.Parent = this.okBtn;
			this.okBtn.Location = new System.Drawing.Point(79, 279);
			this.okBtn.Margin = new System.Windows.Forms.Padding(2);
			this.okBtn.Name = "okBtn";
			this.okBtn.ShadowDecoration.Parent = this.okBtn;
			this.okBtn.Size = new System.Drawing.Size(113, 33);
			this.okBtn.TabIndex = 2;
			this.okBtn.Text = "Ok";
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = global::PlowSense.Properties.Resources.sun;
			this.pictureBox1.Location = new System.Drawing.Point(70, 11);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(131, 123);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// exitImageButton
			// 
			this.exitImageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.exitImageButton.CheckedState.Parent = this.exitImageButton;
			this.exitImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exitImageButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.exitImageButton.HoverState.Parent = this.exitImageButton;
			this.exitImageButton.Image = global::PlowSense.Properties.Resources.icons8_exit_208px;
			this.exitImageButton.ImageRotate = 0F;
			this.exitImageButton.ImageSize = new System.Drawing.Size(24, 24);
			this.exitImageButton.IndicateFocus = true;
			this.exitImageButton.Location = new System.Drawing.Point(230, 7);
			this.exitImageButton.Name = "exitImageButton";
			this.exitImageButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.exitImageButton.PressedState.Parent = this.exitImageButton;
			this.exitImageButton.Size = new System.Drawing.Size(31, 29);
			this.exitImageButton.TabIndex = 4;
			this.exitImageButton.Click += new System.EventHandler(this.guna2ImageButton1_Click);
			// 
			// formShadowForm
			// 
			this.formShadowForm.TargetForm = this;
			// 
			// LinkSheet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(226)))));
			this.ClientSize = new System.Drawing.Size(271, 323);
			this.Controls.Add(this.exitImageButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBoxSheetID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "LinkSheet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.LinkSheet_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2TextBox txtBoxSheetID;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Button okBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2ImageButton exitImageButton;
		private Guna.UI2.WinForms.Guna2ShadowForm formShadowForm;
	}
}