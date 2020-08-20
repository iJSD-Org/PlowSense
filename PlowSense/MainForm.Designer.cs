namespace PlowSense
{
	partial class MainForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.farmsTab = new Guna.UI2.WinForms.Guna2Button();
			this.statsTab = new Guna.UI2.WinForms.Guna2Button();
			this.staffTab = new Guna.UI2.WinForms.Guna2Button();
			this.linkSheetsTab = new Guna.UI2.WinForms.Guna2Button();
			this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dashboardTabControl = new System.Windows.Forms.TabControl();
			this.Farms = new System.Windows.Forms.TabPage();
			this.Statistics = new System.Windows.Forms.TabPage();
			this.Staff = new System.Windows.Forms.TabPage();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.dashboardTabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 15;
			this.guna2Elipse1.TargetControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
			this.panel1.Controls.Add(this.farmsTab);
			this.panel1.Controls.Add(this.statsTab);
			this.panel1.Controls.Add(this.staffTab);
			this.panel1.Controls.Add(this.linkSheetsTab);
			this.panel1.Controls.Add(this.ExitButton);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(100, 576);
			this.panel1.TabIndex = 0;
			// 
			// farmsTab
			// 
			this.farmsTab.Animated = true;
			this.farmsTab.CheckedState.Parent = this.farmsTab;
			this.farmsTab.Cursor = System.Windows.Forms.Cursors.Hand;
			this.farmsTab.CustomImages.Parent = this.farmsTab;
			this.farmsTab.FillColor = System.Drawing.Color.Transparent;
			this.farmsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.farmsTab.ForeColor = System.Drawing.Color.White;
			this.farmsTab.HoverState.Parent = this.farmsTab;
			this.farmsTab.Image = global::PlowSense.Properties.Resources.wfield_208px;
			this.farmsTab.ImageOffset = new System.Drawing.Point(0, 8);
			this.farmsTab.ImageSize = new System.Drawing.Size(50, 50);
			this.farmsTab.Location = new System.Drawing.Point(8, 115);
			this.farmsTab.Name = "farmsTab";
			this.farmsTab.ShadowDecoration.Parent = this.farmsTab;
			this.farmsTab.Size = new System.Drawing.Size(85, 85);
			this.farmsTab.TabIndex = 6;
			this.farmsTab.Text = "Farms     .";
			this.farmsTab.TextOffset = new System.Drawing.Point(0, 13);
			this.farmsTab.Click += new System.EventHandler(this.farmsTab_Click);
			// 
			// statsTab
			// 
			this.statsTab.Animated = true;
			this.statsTab.CheckedState.Parent = this.statsTab;
			this.statsTab.Cursor = System.Windows.Forms.Cursors.Hand;
			this.statsTab.CustomImages.Parent = this.statsTab;
			this.statsTab.FillColor = System.Drawing.Color.Transparent;
			this.statsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statsTab.ForeColor = System.Drawing.Color.White;
			this.statsTab.HoverState.Parent = this.statsTab;
			this.statsTab.Image = global::PlowSense.Properties.Resources.wstatistics_208px;
			this.statsTab.ImageOffset = new System.Drawing.Point(0, 8);
			this.statsTab.ImageSize = new System.Drawing.Size(50, 50);
			this.statsTab.Location = new System.Drawing.Point(8, 206);
			this.statsTab.Name = "statsTab";
			this.statsTab.ShadowDecoration.Parent = this.statsTab;
			this.statsTab.Size = new System.Drawing.Size(85, 85);
			this.statsTab.TabIndex = 5;
			this.statsTab.Text = "Statistics  .";
			this.statsTab.TextOffset = new System.Drawing.Point(0, 13);
			this.statsTab.Click += new System.EventHandler(this.statsTab_Click);
			// 
			// staffTab
			// 
			this.staffTab.Animated = true;
			this.staffTab.CheckedState.Parent = this.staffTab;
			this.staffTab.Cursor = System.Windows.Forms.Cursors.Hand;
			this.staffTab.CustomImages.Parent = this.staffTab;
			this.staffTab.FillColor = System.Drawing.Color.Transparent;
			this.staffTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.staffTab.ForeColor = System.Drawing.Color.White;
			this.staffTab.HoverState.Parent = this.staffTab;
			this.staffTab.Image = global::PlowSense.Properties.Resources.wstaff_96px;
			this.staffTab.ImageOffset = new System.Drawing.Point(0, 8);
			this.staffTab.ImageSize = new System.Drawing.Size(50, 50);
			this.staffTab.Location = new System.Drawing.Point(8, 297);
			this.staffTab.Name = "staffTab";
			this.staffTab.ShadowDecoration.Parent = this.staffTab;
			this.staffTab.Size = new System.Drawing.Size(85, 85);
			this.staffTab.TabIndex = 4;
			this.staffTab.Text = "Staff       .";
			this.staffTab.TextOffset = new System.Drawing.Point(0, 13);
			this.staffTab.Click += new System.EventHandler(this.staffTab_Click);
			// 
			// linkSheetsTab
			// 
			this.linkSheetsTab.Animated = true;
			this.linkSheetsTab.CheckedState.Parent = this.linkSheetsTab;
			this.linkSheetsTab.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkSheetsTab.CustomImages.Parent = this.linkSheetsTab;
			this.linkSheetsTab.FillColor = System.Drawing.Color.Transparent;
			this.linkSheetsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.linkSheetsTab.ForeColor = System.Drawing.Color.White;
			this.linkSheetsTab.HoverState.Parent = this.linkSheetsTab;
			this.linkSheetsTab.Image = global::PlowSense.Properties.Resources.wlink_96px;
			this.linkSheetsTab.ImageOffset = new System.Drawing.Point(0, 3);
			this.linkSheetsTab.ImageSize = new System.Drawing.Size(50, 50);
			this.linkSheetsTab.Location = new System.Drawing.Point(8, 388);
			this.linkSheetsTab.Name = "linkSheetsTab";
			this.linkSheetsTab.ShadowDecoration.Parent = this.linkSheetsTab;
			this.linkSheetsTab.Size = new System.Drawing.Size(85, 85);
			this.linkSheetsTab.TabIndex = 3;
			this.linkSheetsTab.Text = "Link Sheets";
			this.linkSheetsTab.Click += new System.EventHandler(this.linkSheetsTab_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.CheckedState.Parent = this.ExitButton;
			this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ExitButton.CustomImages.Parent = this.ExitButton;
			this.ExitButton.FillColor = System.Drawing.Color.Transparent;
			this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.ExitButton.ForeColor = System.Drawing.Color.White;
			this.ExitButton.HoverState.Parent = this.ExitButton;
			this.ExitButton.Image = global::PlowSense.Properties.Resources.wexit_48px;
			this.ExitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.ExitButton.ImageOffset = new System.Drawing.Point(0, -2);
			this.ExitButton.Location = new System.Drawing.Point(5, 518);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
			this.ExitButton.Size = new System.Drawing.Size(90, 35);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Exit";
			this.ExitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(8, 12);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(85, 85);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// dashboardTabControl
			// 
			this.dashboardTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.dashboardTabControl.Controls.Add(this.Farms);
			this.dashboardTabControl.Controls.Add(this.Statistics);
			this.dashboardTabControl.Controls.Add(this.Staff);
			this.dashboardTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dashboardTabControl.ItemSize = new System.Drawing.Size(0, 1);
			this.dashboardTabControl.Location = new System.Drawing.Point(100, 0);
			this.dashboardTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.dashboardTabControl.Name = "dashboardTabControl";
			this.dashboardTabControl.SelectedIndex = 0;
			this.dashboardTabControl.Size = new System.Drawing.Size(924, 576);
			this.dashboardTabControl.TabIndex = 0;
			// 
			// Farms
			// 
			this.Farms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
			this.Farms.Location = new System.Drawing.Point(4, 5);
			this.Farms.Margin = new System.Windows.Forms.Padding(0);
			this.Farms.Name = "Farms";
			this.Farms.Size = new System.Drawing.Size(916, 567);
			this.Farms.TabIndex = 0;
			this.Farms.Text = "Farms";
			// 
			// Statistics
			// 
			this.Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
			this.Statistics.Location = new System.Drawing.Point(4, 5);
			this.Statistics.Margin = new System.Windows.Forms.Padding(0);
			this.Statistics.Name = "Statistics";
			this.Statistics.Size = new System.Drawing.Size(916, 567);
			this.Statistics.TabIndex = 1;
			this.Statistics.Text = "Statistics";
			// 
			// Staff
			// 
			this.Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
			this.Staff.Location = new System.Drawing.Point(4, 5);
			this.Staff.Margin = new System.Windows.Forms.Padding(0);
			this.Staff.Name = "Staff";
			this.Staff.Size = new System.Drawing.Size(916, 567);
			this.Staff.TabIndex = 2;
			this.Staff.Text = "Staff";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
			this.ClientSize = new System.Drawing.Size(1024, 576);
			this.Controls.Add(this.dashboardTabControl);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.dashboardTabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2Button ExitButton;
		private Guna.UI2.WinForms.Guna2Button linkSheetsTab;
		private Guna.UI2.WinForms.Guna2Button staffTab;
		private Guna.UI2.WinForms.Guna2Button statsTab;
		private Guna.UI2.WinForms.Guna2Button farmsTab;
		private System.Windows.Forms.TabControl dashboardTabControl;
		private System.Windows.Forms.TabPage Farms;
		private System.Windows.Forms.TabPage Statistics;
		private System.Windows.Forms.TabPage Staff;
	}
}

