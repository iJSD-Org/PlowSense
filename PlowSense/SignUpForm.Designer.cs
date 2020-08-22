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
			this.confirmPassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.passTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
			this.enterButton = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
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
			this.exitImageButton.Click += new System.EventHandler(this.exitImageButton_Click);
			// 
			// confirmPassTextBox
			// 
			this.confirmPassTextBox.Animated = true;
			this.confirmPassTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
			this.confirmPassTextBox.BorderThickness = 2;
			this.confirmPassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.confirmPassTextBox.DefaultText = "";
			this.confirmPassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.confirmPassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.confirmPassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.confirmPassTextBox.DisabledState.Parent = this.confirmPassTextBox;
			this.confirmPassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.confirmPassTextBox.FillColor = System.Drawing.SystemColors.Control;
			this.confirmPassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.confirmPassTextBox.FocusedState.Parent = this.confirmPassTextBox;
			this.confirmPassTextBox.Font = new System.Drawing.Font("Proxima Soft", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmPassTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.confirmPassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.confirmPassTextBox.HoverState.Parent = this.confirmPassTextBox;
			this.confirmPassTextBox.IconLeft = global::PlowSense.Properties.Resources.icons8_password_208px;
			this.confirmPassTextBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.confirmPassTextBox.Location = new System.Drawing.Point(32, 103);
			this.confirmPassTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.confirmPassTextBox.Name = "confirmPassTextBox";
			this.confirmPassTextBox.PasswordChar = '*';
			this.confirmPassTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.confirmPassTextBox.PlaceholderText = "Confirm Password";
			this.confirmPassTextBox.SelectedText = "";
			this.confirmPassTextBox.ShadowDecoration.Parent = this.confirmPassTextBox;
			this.confirmPassTextBox.ShortcutsEnabled = false;
			this.confirmPassTextBox.Size = new System.Drawing.Size(186, 33);
			this.confirmPassTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.confirmPassTextBox.TabIndex = 12;
			this.confirmPassTextBox.TextChanged += new System.EventHandler(this.signUpTextBox_TextChanged);
			this.confirmPassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signUpTextBox_KeyPress);
			// 
			// passTextBox
			// 
			this.passTextBox.Animated = true;
			this.passTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
			this.passTextBox.BorderThickness = 2;
			this.passTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.passTextBox.DefaultText = "";
			this.passTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.passTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.passTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passTextBox.DisabledState.Parent = this.passTextBox;
			this.passTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passTextBox.FillColor = System.Drawing.SystemColors.Control;
			this.passTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.passTextBox.FocusedState.Parent = this.passTextBox;
			this.passTextBox.Font = new System.Drawing.Font("Proxima Soft", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.passTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.passTextBox.HoverState.Parent = this.passTextBox;
			this.passTextBox.IconLeft = global::PlowSense.Properties.Resources.icons8_password_208px;
			this.passTextBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.passTextBox.Location = new System.Drawing.Point(32, 62);
			this.passTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.passTextBox.Name = "passTextBox";
			this.passTextBox.PasswordChar = '*';
			this.passTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.passTextBox.PlaceholderText = "Password";
			this.passTextBox.SelectedText = "";
			this.passTextBox.ShadowDecoration.Parent = this.passTextBox;
			this.passTextBox.ShortcutsEnabled = false;
			this.passTextBox.Size = new System.Drawing.Size(186, 33);
			this.passTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.passTextBox.TabIndex = 10;
			this.passTextBox.TextChanged += new System.EventHandler(this.signUpTextBox_TextChanged);
			this.passTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signUpTextBox_KeyPress);
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
			this.usernameTextBox.ShortcutsEnabled = false;
			this.usernameTextBox.Size = new System.Drawing.Size(186, 33);
			this.usernameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.usernameTextBox.TabIndex = 9;
			this.usernameTextBox.TextChanged += new System.EventHandler(this.signUpTextBox_TextChanged);
			this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signUpTextBox_KeyPress);
			// 
			// backgroundPictureBox
			// 
			this.backgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.backgroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.Image")));
			this.backgroundPictureBox.Location = new System.Drawing.Point(0, 186);
			this.backgroundPictureBox.Name = "backgroundPictureBox";
			this.backgroundPictureBox.Size = new System.Drawing.Size(263, 139);
			this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.backgroundPictureBox.TabIndex = 13;
			this.backgroundPictureBox.TabStop = false;
			// 
			// enterButton
			// 
			this.enterButton.Animated = true;
			this.enterButton.AutoRoundedCorners = true;
			this.enterButton.BackColor = System.Drawing.Color.Transparent;
			this.enterButton.BorderRadius = 18;
			this.enterButton.CheckedState.Parent = this.enterButton;
			this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.enterButton.CustomImages.Parent = this.enterButton;
			this.enterButton.Enabled = false;
			this.enterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(120)))), ((int)(((byte)(171)))));
			this.enterButton.Font = new System.Drawing.Font("Proxima Soft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enterButton.ForeColor = System.Drawing.Color.White;
			this.enterButton.HoverState.Parent = this.enterButton;
			this.enterButton.Location = new System.Drawing.Point(61, 148);
			this.enterButton.Name = "enterButton";
			this.enterButton.ShadowDecoration.Parent = this.enterButton;
			this.enterButton.Size = new System.Drawing.Size(129, 39);
			this.enterButton.TabIndex = 15;
			this.enterButton.Text = "Signup";
			this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
			// 
			// SignUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(263, 325);
			this.Controls.Add(this.enterButton);
			this.Controls.Add(this.confirmPassTextBox);
			this.Controls.Add(this.passTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.backgroundPictureBox);
			this.Controls.Add(this.exitImageButton);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUpForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Signup";
			((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse formElipse;
		private Guna.UI2.WinForms.Guna2TextBox confirmPassTextBox;
		private Guna.UI2.WinForms.Guna2TextBox passTextBox;
		private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
		private System.Windows.Forms.PictureBox backgroundPictureBox;
		private Guna.UI2.WinForms.Guna2ShadowForm formShadowForm;
		private Guna.UI2.WinForms.Guna2AnimateWindow formAnimateWindow;
		private Guna.UI2.WinForms.Guna2ImageButton exitImageButton;
		private Guna.UI2.WinForms.Guna2Button enterButton;
	}
}