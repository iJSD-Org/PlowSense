namespace PlowSense
{
	partial class SignUpForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
			this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.formShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.formAnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.exitImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
			this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// formElipse
			// 
			this.formElipse.BorderRadius = 25;
			this.formElipse.TargetControl = this;
			// 
			// formShadowForm
			// 
			this.formShadowForm.TargetForm = this;
			// 
			// formAnimateWindow
			// 
			this.formAnimateWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
			this.formAnimateWindow.TargetForm = this;
			// 
			// exitImageButton
			// 
			this.exitImageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.exitImageButton.CheckedState.Parent = this.exitImageButton;
			this.exitImageButton.HoverState.ImageSize = new System.Drawing.Size(35, 35);
			this.exitImageButton.HoverState.Parent = this.exitImageButton;
			this.exitImageButton.Image = global::PlowSense.Properties.Resources.icons8_delete_208px_1;
			this.exitImageButton.ImageRotate = 0F;
			this.exitImageButton.ImageSize = new System.Drawing.Size(25, 25);
			this.exitImageButton.Location = new System.Drawing.Point(205, -13);
			this.exitImageButton.Name = "exitImageButton";
			this.exitImageButton.PressedState.ImageSize = new System.Drawing.Size(50, 50);
			this.exitImageButton.PressedState.Parent = this.exitImageButton;
			this.exitImageButton.Size = new System.Drawing.Size(67, 67);
			this.exitImageButton.TabIndex = 14;
			this.exitImageButton.Click += new System.EventHandler(this.guna2ImageButton1_Click);
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Animated = true;
			this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
			this.guna2TextBox1.BorderThickness = 2;
			this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.FillColor = System.Drawing.SystemColors.Control;
			this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
			this.guna2TextBox1.Font = new System.Drawing.Font("Proxima Soft", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
			this.guna2TextBox1.IconLeft = global::PlowSense.Properties.Resources.icons8_password_208px;
			this.guna2TextBox1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.guna2TextBox1.Location = new System.Drawing.Point(32, 103);
			this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '*';
			this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.guna2TextBox1.PlaceholderText = "Confirm Password";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
			this.guna2TextBox1.Size = new System.Drawing.Size(186, 33);
			this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.guna2TextBox1.TabIndex = 12;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Animated = true;
			this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
			this.passwordTextBox.BorderThickness = 2;
			this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.passwordTextBox.DefaultText = "";
			this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passwordTextBox.DisabledState.Parent = this.passwordTextBox;
			this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passwordTextBox.FillColor = System.Drawing.SystemColors.Control;
			this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.passwordTextBox.FocusedState.Parent = this.passwordTextBox;
			this.passwordTextBox.Font = new System.Drawing.Font("Proxima Soft", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.passwordTextBox.HoverState.Parent = this.passwordTextBox;
			this.passwordTextBox.IconLeft = global::PlowSense.Properties.Resources.icons8_password_208px;
			this.passwordTextBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.passwordTextBox.Location = new System.Drawing.Point(32, 62);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.passwordTextBox.PlaceholderText = "Password";
			this.passwordTextBox.SelectedText = "";
			this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
			this.passwordTextBox.Size = new System.Drawing.Size(186, 33);
			this.passwordTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.passwordTextBox.TabIndex = 10;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Animated = true;
			this.usernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
			this.usernameTextBox.BorderThickness = 2;
			this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.usernameTextBox.DefaultText = "";
			this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.usernameTextBox.DisabledState.Parent = this.usernameTextBox;
			this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.usernameTextBox.FillColor = System.Drawing.SystemColors.Control;
			this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.usernameTextBox.FocusedState.Parent = this.usernameTextBox;
			this.usernameTextBox.Font = new System.Drawing.Font("Proxima Soft", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.usernameTextBox.HoverState.Parent = this.usernameTextBox;
			this.usernameTextBox.IconLeft = global::PlowSense.Properties.Resources.icons8_user_account_208px;
			this.usernameTextBox.Location = new System.Drawing.Point(32, 21);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.PasswordChar = '\0';
			this.usernameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.usernameTextBox.PlaceholderText = "Username";
			this.usernameTextBox.SelectedText = "";
			this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
			this.usernameTextBox.Size = new System.Drawing.Size(193, 33);
			this.usernameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.usernameTextBox.TabIndex = 9;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 186);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(263, 139);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// guna2Button1
			// 
			this.guna2Button1.Animated = true;
			this.guna2Button1.AutoRoundedCorners = true;
			this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 18;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(120)))), ((int)(((byte)(171)))));
			this.guna2Button1.Font = new System.Drawing.Font("Proxima Soft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new System.Drawing.Point(61, 148);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new System.Drawing.Size(129, 39);
			this.guna2Button1.TabIndex = 15;
			this.guna2Button1.Text = "Sign-up";
			// 
			// SignUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(263, 325);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.guna2TextBox1);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.exitImageButton);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUpForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Control";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse formElipse;
		private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
		private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
		private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2ShadowForm formShadowForm;
		private Guna.UI2.WinForms.Guna2AnimateWindow formAnimateWindow;
		private Guna.UI2.WinForms.Guna2ImageButton exitImageButton;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
	}
}