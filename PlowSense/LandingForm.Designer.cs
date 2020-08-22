namespace PlowSense
{
	sealed partial class LandingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
			this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.loginLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.leftPanel = new System.Windows.Forms.Panel();
			this.verticalSeparatorPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.rightPanel = new System.Windows.Forms.Panel();
			this.exitImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
			this.loginButton = new Guna.UI2.WinForms.Guna2Button();
			this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.formAnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.form2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.formDragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.leftPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.rightPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// formElipse
			// 
			this.formElipse.BorderRadius = 25;
			this.formElipse.TargetControl = this;
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Font = new System.Drawing.Font("Proxima Soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.loginLabel.Location = new System.Drawing.Point(37, 46);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(89, 31);
			this.loginLabel.TabIndex = 2;
			this.loginLabel.Text = "Log in";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.leftPanel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.rightPanel, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 395F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 395);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// leftPanel
			// 
			this.leftPanel.BackColor = System.Drawing.Color.Transparent;
			this.leftPanel.Controls.Add(this.verticalSeparatorPanel);
			this.leftPanel.Controls.Add(this.signUpLinkLabel);
			this.leftPanel.Controls.Add(this.logoPictureBox);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(382, 395);
			this.leftPanel.TabIndex = 0;
			// 
			// verticalSeparatorPanel
			// 
			this.verticalSeparatorPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
			this.verticalSeparatorPanel.Location = new System.Drawing.Point(379, 46);
			this.verticalSeparatorPanel.Name = "verticalSeparatorPanel";
			this.verticalSeparatorPanel.ShadowDecoration.Parent = this.verticalSeparatorPanel;
			this.verticalSeparatorPanel.Size = new System.Drawing.Size(2, 275);
			this.verticalSeparatorPanel.TabIndex = 3;
			// 
			// signUpLinkLabel
			// 
			this.signUpLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.signUpLinkLabel.AutoSize = true;
			this.signUpLinkLabel.Font = new System.Drawing.Font("Proxima Soft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signUpLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.signUpLinkLabel.Location = new System.Drawing.Point(175, 135);
			this.signUpLinkLabel.Name = "signUpLinkLabel";
			this.signUpLinkLabel.Size = new System.Drawing.Size(136, 18);
			this.signUpLinkLabel.TabIndex = 1;
			this.signUpLinkLabel.TabStop = true;
			this.signUpLinkLabel.Text = "Create an account";
			this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = global::PlowSense.Properties.Resources.logo;
			this.logoPictureBox.Location = new System.Drawing.Point(84, 12);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(227, 141);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 0;
			this.logoPictureBox.TabStop = false;
			// 
			// rightPanel
			// 
			this.rightPanel.BackColor = System.Drawing.Color.Transparent;
			this.rightPanel.Controls.Add(this.exitImageButton);
			this.rightPanel.Controls.Add(this.loginButton);
			this.rightPanel.Controls.Add(this.passwordTextBox);
			this.rightPanel.Controls.Add(this.usernameTextBox);
			this.rightPanel.Controls.Add(this.loginLabel);
			this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightPanel.Location = new System.Drawing.Point(382, 0);
			this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
			this.rightPanel.Name = "rightPanel";
			this.rightPanel.Size = new System.Drawing.Size(382, 395);
			this.rightPanel.TabIndex = 1;
			// 
			// exitImageButton
			// 
			this.exitImageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.exitImageButton.CheckedState.Parent = this.exitImageButton;
			this.exitImageButton.HoverState.ImageSize = new System.Drawing.Size(35, 35);
			this.exitImageButton.HoverState.Parent = this.exitImageButton;
			this.exitImageButton.Image = global::PlowSense.Properties.Resources.icons8_exit_208px;
			this.exitImageButton.ImageRotate = 0F;
			this.exitImageButton.ImageSize = new System.Drawing.Size(25, 25);
			this.exitImageButton.Location = new System.Drawing.Point(325, -10);
			this.exitImageButton.Name = "exitImageButton";
			this.exitImageButton.PressedState.ImageSize = new System.Drawing.Size(50, 50);
			this.exitImageButton.PressedState.Parent = this.exitImageButton;
			this.exitImageButton.Size = new System.Drawing.Size(67, 67);
			this.exitImageButton.TabIndex = 15;
			this.exitImageButton.Click += new System.EventHandler(this.exitImageButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Animated = true;
			this.loginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
			this.loginButton.BorderRadius = 14;
			this.loginButton.BorderThickness = 2;
			this.loginButton.CheckedState.Parent = this.loginButton;
			this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginButton.CustomImages.Parent = this.loginButton;
			this.loginButton.Enabled = false;
			this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
			this.loginButton.Font = new System.Drawing.Font("Proxima Soft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.loginButton.HoverState.BorderColor = System.Drawing.Color.Transparent;
			this.loginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.loginButton.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
			this.loginButton.HoverState.Parent = this.loginButton;
			this.loginButton.Location = new System.Drawing.Point(43, 264);
			this.loginButton.Name = "loginButton";
			this.loginButton.ShadowDecoration.Parent = this.loginButton;
			this.loginButton.Size = new System.Drawing.Size(136, 33);
			this.loginButton.TabIndex = 7;
			this.loginButton.Text = "Login";
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
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
			this.passwordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
			this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.passwordTextBox.FocusedState.Parent = this.passwordTextBox;
			this.passwordTextBox.Font = new System.Drawing.Font("Proxima Soft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.passwordTextBox.HoverState.Parent = this.passwordTextBox;
			this.passwordTextBox.IconLeft = global::PlowSense.Properties.Resources.icons8_password_208px;
			this.passwordTextBox.IconLeftSize = new System.Drawing.Size(25, 25);
			this.passwordTextBox.IconRight = global::PlowSense.Properties.Resources.icons8_hide_512px;
			this.passwordTextBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.passwordTextBox.IconRightSize = new System.Drawing.Size(25, 25);
			this.passwordTextBox.Location = new System.Drawing.Point(43, 149);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.passwordTextBox.PlaceholderText = "Password";
			this.passwordTextBox.SelectedText = "";
			this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
			this.passwordTextBox.ShortcutsEnabled = false;
			this.passwordTextBox.Size = new System.Drawing.Size(263, 44);
			this.passwordTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.passwordTextBox.TabIndex = 6;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
			this.passwordTextBox.IconRightClick += new System.EventHandler(this.passwordTextBox_IconRightClick);
			this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
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
			this.usernameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
			this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.usernameTextBox.FocusedState.Parent = this.usernameTextBox;
			this.usernameTextBox.Font = new System.Drawing.Font("Proxima Soft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(103)))));
			this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.usernameTextBox.HoverState.Parent = this.usernameTextBox;
			this.usernameTextBox.IconLeft = global::PlowSense.Properties.Resources.icons8_user_account_208px;
			this.usernameTextBox.IconLeftSize = new System.Drawing.Size(25, 25);
			this.usernameTextBox.Location = new System.Drawing.Point(43, 97);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.PasswordChar = '\0';
			this.usernameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.usernameTextBox.PlaceholderText = "Username";
			this.usernameTextBox.SelectedText = "";
			this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
			this.usernameTextBox.ShortcutsEnabled = false;
			this.usernameTextBox.Size = new System.Drawing.Size(263, 44);
			this.usernameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.usernameTextBox.TabIndex = 5;
			this.usernameTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
			this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// formAnimateWindow
			// 
			this.formAnimateWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
			this.formAnimateWindow.TargetForm = this;
			// 
			// form2DragControl1
			// 
			this.form2DragControl1.TargetControl = this.leftPanel;
			// 
			// formDragControl2
			// 
			this.formDragControl2.TargetControl = this.rightPanel;
			// 
			// LandingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(764, 395);
			this.Controls.Add(this.tableLayoutPanel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LandingForm";
			this.Text = "LandingForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandingForm_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.rightPanel.ResumeLayout(false);
			this.rightPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse formElipse;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Panel rightPanel;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.LinkLabel signUpLinkLabel;
		private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
		private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
		private Guna.UI2.WinForms.Guna2Button loginButton;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private Guna.UI2.WinForms.Guna2Panel verticalSeparatorPanel;
		private Guna.UI2.WinForms.Guna2AnimateWindow formAnimateWindow;
		private Guna.UI2.WinForms.Guna2DragControl form2DragControl1;
		private Guna.UI2.WinForms.Guna2DragControl formDragControl2;
		private Guna.UI2.WinForms.Guna2ImageButton exitImageButton;
	}
}