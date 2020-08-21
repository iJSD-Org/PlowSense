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
			this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.dashboardTabControl = new System.Windows.Forms.TabControl();
			this.Farms = new System.Windows.Forms.TabPage();
			this.Statistics = new System.Windows.Forms.TabPage();
			this.Staff = new System.Windows.Forms.TabPage();
			this.sidebarPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.linkSheetsButton = new Guna.UI2.WinForms.Guna2Button();
			this.staffTileButton = new Guna.UI2.WinForms.Guna2TileButton();
			this.farmsTileButton = new Guna.UI2.WinForms.Guna2TileButton();
			this.statsTileButton = new Guna.UI2.WinForms.Guna2TileButton();
			this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.dashboardTabControl.SuspendLayout();
			this.sidebarPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// formElipse
			// 
			this.formElipse.BorderRadius = 35;
			this.formElipse.TargetControl = this;
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
			this.Farms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
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
			// sidebarPanel
			// 
			this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
			this.sidebarPanel.Controls.Add(this.linkSheetsButton);
			this.sidebarPanel.Controls.Add(this.staffTileButton);
			this.sidebarPanel.Controls.Add(this.farmsTileButton);
			this.sidebarPanel.Controls.Add(this.statsTileButton);
			this.sidebarPanel.Controls.Add(this.ExitButton);
			this.sidebarPanel.Controls.Add(this.pictureBox1);
			this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebarPanel.FillColor = System.Drawing.Color.Yellow;
			this.sidebarPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.sidebarPanel.FillColor3 = System.Drawing.Color.DarkGreen;
			this.sidebarPanel.FillColor4 = System.Drawing.Color.DarkGreen;
			this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
			this.sidebarPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.sidebarPanel.Name = "sidebarPanel";
			this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
			this.sidebarPanel.Size = new System.Drawing.Size(100, 576);
			this.sidebarPanel.TabIndex = 0;
			// 
			// linkSheetsButton
			// 
			this.linkSheetsButton.Animated = true;
			this.linkSheetsButton.BackColor = System.Drawing.Color.Transparent;
			this.linkSheetsButton.CheckedState.Parent = this.linkSheetsButton;
			this.linkSheetsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkSheetsButton.CustomImages.Image = global::PlowSense.Properties.Resources.wlink_96px;
			this.linkSheetsButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.linkSheetsButton.CustomImages.Parent = this.linkSheetsButton;
			this.linkSheetsButton.FillColor = System.Drawing.Color.Transparent;
			this.linkSheetsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkSheetsButton.ForeColor = System.Drawing.Color.White;
			this.linkSheetsButton.HoverState.Parent = this.linkSheetsButton;
			this.linkSheetsButton.Image = global::PlowSense.Properties.Resources.wlink_96px;
			this.linkSheetsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.linkSheetsButton.Location = new System.Drawing.Point(0, 452);
			this.linkSheetsButton.Name = "linkSheetsButton";
			this.linkSheetsButton.ShadowDecoration.Parent = this.linkSheetsButton;
			this.linkSheetsButton.Size = new System.Drawing.Size(101, 60);
			this.linkSheetsButton.TabIndex = 0;
			this.linkSheetsButton.Text = "Link Sheets     .";
			this.linkSheetsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.linkSheetsButton.Click += new System.EventHandler(this.linkSheetsButton_Click);
			// 
			// staffTileButton
			// 
			this.staffTileButton.Animated = true;
			this.staffTileButton.BackColor = System.Drawing.Color.Transparent;
			this.staffTileButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
			this.staffTileButton.BorderRadius = 12;
			this.staffTileButton.CheckedState.Parent = this.staffTileButton;
			this.staffTileButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.staffTileButton.CustomImages.Parent = this.staffTileButton;
			this.staffTileButton.FillColor = System.Drawing.Color.Transparent;
			this.staffTileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.staffTileButton.ForeColor = System.Drawing.Color.White;
			this.staffTileButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
			this.staffTileButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
			this.staffTileButton.HoverState.Parent = this.staffTileButton;
			this.staffTileButton.Image = global::PlowSense.Properties.Resources.target;
			this.staffTileButton.ImageOffset = new System.Drawing.Point(0, 10);
			this.staffTileButton.ImageSize = new System.Drawing.Size(55, 55);
			this.staffTileButton.Location = new System.Drawing.Point(8, 291);
			this.staffTileButton.Name = "staffTileButton";
			this.staffTileButton.ShadowDecoration.Parent = this.staffTileButton;
			this.staffTileButton.Size = new System.Drawing.Size(85, 89);
			this.staffTileButton.TabIndex = 8;
			this.staffTileButton.Text = "Staff";
			this.staffTileButton.TextOffset = new System.Drawing.Point(0, -5);
			this.guna2HtmlToolTip1.SetToolTip(this.staffTileButton, "View/Add staff");
			this.staffTileButton.Click += new System.EventHandler(this.staffTileButton_Click);
			// 
			// farmsTileButton
			// 
			this.farmsTileButton.Animated = true;
			this.farmsTileButton.BackColor = System.Drawing.Color.Transparent;
			this.farmsTileButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
			this.farmsTileButton.BorderRadius = 12;
			this.farmsTileButton.CheckedState.Parent = this.farmsTileButton;
			this.farmsTileButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.farmsTileButton.CustomImages.Parent = this.farmsTileButton;
			this.farmsTileButton.FillColor = System.Drawing.Color.Transparent;
			this.farmsTileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.farmsTileButton.ForeColor = System.Drawing.Color.White;
			this.farmsTileButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
			this.farmsTileButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
			this.farmsTileButton.HoverState.Parent = this.farmsTileButton;
			this.farmsTileButton.Image = global::PlowSense.Properties.Resources.field;
			this.farmsTileButton.ImageOffset = new System.Drawing.Point(0, 10);
			this.farmsTileButton.ImageSize = new System.Drawing.Size(50, 50);
			this.farmsTileButton.Location = new System.Drawing.Point(8, 114);
			this.farmsTileButton.Name = "farmsTileButton";
			this.farmsTileButton.ShadowDecoration.Parent = this.farmsTileButton;
			this.farmsTileButton.Size = new System.Drawing.Size(85, 89);
			this.farmsTileButton.TabIndex = 7;
			this.farmsTileButton.Text = "Farms";
			this.guna2HtmlToolTip1.SetToolTip(this.farmsTileButton, "View/Add registered farms");
			this.farmsTileButton.Click += new System.EventHandler(this.farmsTileButton_Click);
			// 
			// statsTileButton
			// 
			this.statsTileButton.Animated = true;
			this.statsTileButton.BackColor = System.Drawing.Color.Transparent;
			this.statsTileButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
			this.statsTileButton.BorderRadius = 12;
			this.statsTileButton.CheckedState.Parent = this.statsTileButton;
			this.statsTileButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.statsTileButton.CustomImages.Parent = this.statsTileButton;
			this.statsTileButton.FillColor = System.Drawing.Color.Transparent;
			this.statsTileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statsTileButton.ForeColor = System.Drawing.Color.White;
			this.statsTileButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
			this.statsTileButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
			this.statsTileButton.HoverState.Parent = this.statsTileButton;
			this.statsTileButton.Image = global::PlowSense.Properties.Resources.graph_line_screen;
			this.statsTileButton.ImageOffset = new System.Drawing.Point(0, 10);
			this.statsTileButton.ImageSize = new System.Drawing.Size(50, 50);
			this.statsTileButton.Location = new System.Drawing.Point(8, 202);
			this.statsTileButton.Name = "statsTileButton";
			this.statsTileButton.ShadowDecoration.Parent = this.statsTileButton;
			this.statsTileButton.Size = new System.Drawing.Size(85, 89);
			this.statsTileButton.TabIndex = 0;
			this.statsTileButton.Text = "Statistics";
			this.guna2HtmlToolTip1.SetToolTip(this.statsTileButton, "View the general statistics");
			this.statsTileButton.Click += new System.EventHandler(this.statsTileButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.Transparent;
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
			this.ExitButton.Location = new System.Drawing.Point(0, 518);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
			this.ExitButton.Size = new System.Drawing.Size(101, 35);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Exit";
			this.ExitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Location = new System.Drawing.Point(8, 12);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(85, 85);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// formDragControl
			// 
			this.formDragControl.TargetControl = this.sidebarPanel;
			this.formDragControl.UseTransparentDrag = true;
			// 
			// guna2HtmlToolTip1
			// 
			this.guna2HtmlToolTip1.AllowLinksHandling = true;
			this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(1024, 576);
			this.Controls.Add(this.dashboardTabControl);
			this.Controls.Add(this.sidebarPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.dashboardTabControl.ResumeLayout(false);
			this.sidebarPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
		private System.Windows.Forms.TabControl dashboardTabControl;
		private System.Windows.Forms.TabPage Farms;
		private System.Windows.Forms.TabPage Statistics;
		private System.Windows.Forms.TabPage Staff;
		private Guna.UI2.WinForms.Guna2DragControl formDragControl;
		private Guna.UI2.WinForms.Guna2TileButton statsTileButton;
		private Guna.UI2.WinForms.Guna2TileButton staffTileButton;
		private Guna.UI2.WinForms.Guna2CustomGradientPanel sidebarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2Button linkSheetsButton;
		private Guna.UI2.WinForms.Guna2Button ExitButton;
		private Guna.UI2.WinForms.Guna2TileButton farmsTileButton;
		private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
	}
}

