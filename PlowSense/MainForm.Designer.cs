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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.staffTab = new Guna.UI2.WinForms.Guna2ImageButton();
            this.statsTab = new Guna.UI2.WinForms.Guna2ImageButton();
            this.farmsTab = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dashBoardPanel = new System.Windows.Forms.Panel();
            this.linkSheetsTab = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkSheetsTab);
            this.panel1.Controls.Add(this.staffTab);
            this.panel1.Controls.Add(this.statsTab);
            this.panel1.Controls.Add(this.farmsTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 572);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // staffTab
            // 
            this.staffTab.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.staffTab.CheckedState.Parent = this.staffTab;
            this.staffTab.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.staffTab.HoverState.Parent = this.staffTab;
            this.staffTab.Image = ((System.Drawing.Image)(resources.GetObject("staffTab.Image")));
            this.staffTab.ImageRotate = 0F;
            this.staffTab.Location = new System.Drawing.Point(12, 344);
            this.staffTab.Name = "staffTab";
            this.staffTab.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.staffTab.PressedState.Parent = this.staffTab;
            this.staffTab.Size = new System.Drawing.Size(64, 64);
            this.staffTab.TabIndex = 0;
            this.staffTab.Click += new System.EventHandler(this.staffTab_Click);
            // 
            // statsTab
            // 
            this.statsTab.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.statsTab.CheckedState.Parent = this.statsTab;
            this.statsTab.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.statsTab.HoverState.Parent = this.statsTab;
            this.statsTab.Image = ((System.Drawing.Image)(resources.GetObject("statsTab.Image")));
            this.statsTab.ImageRotate = 0F;
            this.statsTab.Location = new System.Drawing.Point(12, 252);
            this.statsTab.Name = "statsTab";
            this.statsTab.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.statsTab.PressedState.Parent = this.statsTab;
            this.statsTab.Size = new System.Drawing.Size(64, 64);
            this.statsTab.TabIndex = 0;
            this.statsTab.Click += new System.EventHandler(this.statsTab_Click);
            // 
            // farmsTab
            // 
            this.farmsTab.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.farmsTab.CheckedState.Parent = this.farmsTab;
            this.farmsTab.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.farmsTab.HoverState.Parent = this.farmsTab;
            this.farmsTab.Image = ((System.Drawing.Image)(resources.GetObject("farmsTab.Image")));
            this.farmsTab.ImageRotate = 0F;
            this.farmsTab.Location = new System.Drawing.Point(12, 155);
            this.farmsTab.Name = "farmsTab";
            this.farmsTab.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.farmsTab.PressedState.Parent = this.farmsTab;
            this.farmsTab.Size = new System.Drawing.Size(64, 64);
            this.farmsTab.TabIndex = 0;
            this.farmsTab.Click += new System.EventHandler(this.farmsTab_Click);
            // 
            // dashBoardPanel
            // 
            this.dashBoardPanel.Location = new System.Drawing.Point(100, 12);
            this.dashBoardPanel.Name = "dashBoardPanel";
            this.dashBoardPanel.Size = new System.Drawing.Size(912, 548);
            this.dashBoardPanel.TabIndex = 1;
            // 
            // linkSheetsTab
            // 
            this.linkSheetsTab.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.linkSheetsTab.CheckedState.Parent = this.linkSheetsTab;
            this.linkSheetsTab.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.linkSheetsTab.HoverState.Parent = this.linkSheetsTab;
            this.linkSheetsTab.Image = ((System.Drawing.Image)(resources.GetObject("linkSheetsTab.Image")));
            this.linkSheetsTab.ImageRotate = 0F;
            this.linkSheetsTab.Location = new System.Drawing.Point(12, 437);
            this.linkSheetsTab.Name = "linkSheetsTab";
            this.linkSheetsTab.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.linkSheetsTab.PressedState.Parent = this.linkSheetsTab;
            this.linkSheetsTab.Size = new System.Drawing.Size(64, 64);
            this.linkSheetsTab.TabIndex = 0;
            this.linkSheetsTab.Click += new System.EventHandler(this.linkSheetsTab_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1024, 572);
            this.Controls.Add(this.dashBoardPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton statsTab;
        private Guna.UI2.WinForms.Guna2ImageButton farmsTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton staffTab;
        private System.Windows.Forms.Panel dashBoardPanel;
		private Guna.UI2.WinForms.Guna2ImageButton linkSheetsTab;
	}
}

