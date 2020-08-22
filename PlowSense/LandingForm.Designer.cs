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
			this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.logInLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.leftPanel = new System.Windows.Forms.Panel();
			this.verticalSeparatorPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
			this.rightPanel = new System.Windows.Forms.Panel();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.formAnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.form2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.formDragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.leftPanel.SuspendLayout();
			this.rightPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// formElipse
			// 
			this.formElipse.BorderRadius = 25;
			this.formElipse.TargetControl = this;
			// 
			// logInLabel
			// 
			this.logInLabel.AutoSize = true;
			this.logInLabel.Font = new System.Drawing.Font("Proxima Soft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.logInLabel.Location = new System.Drawing.Point(37, 46);
			this.logInLabel.Name = "logInLabel";
			this.logInLabel.Size = new System.Drawing.Size(89, 31);
			this.logInLabel.TabIndex = 2;
			this.logInLabel.Text = "Log in";
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
			this.leftPanel.Controls.Add(this.pictureBox1);
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
			// rightPanel
			// 
			this.rightPanel.BackColor = System.Drawing.Color.Transparent;
			this.rightPanel.Controls.Add(this.guna2ImageButton1);
			this.rightPanel.Controls.Add(this.guna2Button1);
			this.rightPanel.Controls.Add(this.passwordTextBox);
			this.rightPanel.Controls.Add(this.usernameTextBox);
			this.rightPanel.Controls.Add(this.logInLabel);
			this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightPanel.Location = new System.Drawing.Point(382, 0);
			this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
			this.rightPanel.Name = "rightPanel";
			this.rightPanel.Size = new System.Drawing.Size(382, 395);
			this.rightPanel.TabIndex = 1;
			// 
			// guna2Button1
			// 
			this.guna2Button1.Animated = true;
			this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
			this.guna2Button1.BorderRadius = 14;
			this.guna2Button1.BorderThickness = 2;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
			this.guna2Button1.Font = new System.Drawing.Font("Proxima Soft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Transparent;
			this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new System.Drawing.Point(43, 264);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new System.Drawing.Size(136, 33);
			this.guna2Button1.TabIndex = 7;
			this.guna2Button1.Text = "Login";
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
			// guna2ImageButton1
			// 
			this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
			this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(35, 35);
			this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
			this.guna2ImageButton1.Image = global::PlowSense.Properties.Resources.icons8_exit_208px;
			this.guna2ImageButton1.ImageRotate = 0F;
			this.guna2ImageButton1.ImageSize = new System.Drawing.Size(25, 25);
			this.guna2ImageButton1.Location = new System.Drawing.Point(325, -10);
			this.guna2ImageButton1.Name = "guna2ImageButton1";
			this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(50, 50);
			this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
			this.guna2ImageButton1.Size = new System.Drawing.Size(67, 67);
			this.guna2ImageButton1.TabIndex = 15;
			this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PlowSense.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(84, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(227, 141);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
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
			this.passwordTextBox.Size = new System.Drawing.Size(263, 44);
			this.passwordTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.passwordTextBox.TabIndex = 6;
			this.passwordTextBox.IconRightClick += new System.EventHandler(this.passwordTextBox_IconRightClick);
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
			this.usernameTextBox.Size = new System.Drawing.Size(263, 44);
			this.usernameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.usernameTextBox.TabIndex = 5;
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
			this.Name = "LandingForm";
			this.Text = "LandingForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.rightPanel.ResumeLayout(false);
			this.rightPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse formElipse;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Panel rightPanel;
		private System.Windows.Forms.Label logInLabel;
		private System.Windows.Forms.LinkLabel signUpLinkLabel;
		private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
		private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2Panel verticalSeparatorPanel;
		private Guna.UI2.WinForms.Guna2AnimateWindow formAnimateWindow;
		private Guna.UI2.WinForms.Guna2DragControl form2DragControl1;
		private Guna.UI2.WinForms.Guna2DragControl formDragControl2;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
	}
}