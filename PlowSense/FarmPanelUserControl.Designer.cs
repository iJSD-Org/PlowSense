namespace PlowSense
{
	partial class FarmPanelUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FarmName = new System.Windows.Forms.Label();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.flowPanel;
            // 
            // flowPanel
            // 
            this.flowPanel.BackColor = System.Drawing.Color.White;
            this.flowPanel.Location = new System.Drawing.Point(12, 39);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(430, 101);
            this.flowPanel.TabIndex = 16;
            this.flowPanel.WrapContents = false;
            // 
            // FarmName
            // 
            this.FarmName.AutoSize = true;
            this.FarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FarmName.ForeColor = System.Drawing.Color.White;
            this.FarmName.Location = new System.Drawing.Point(10, 7);
            this.FarmName.Name = "FarmName";
            this.FarmName.Size = new System.Drawing.Size(132, 25);
            this.FarmName.TabIndex = 14;
            this.FarmName.Text = "Farm Name";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator4.FillColor = System.Drawing.Color.White;
            this.guna2Separator4.FillThickness = 2;
            this.guna2Separator4.Location = new System.Drawing.Point(15, 28);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(132, 10);
            this.guna2Separator4.TabIndex = 15;
            // 
            // FarmPanelUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(143)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.FarmName);
            this.Controls.Add(this.guna2Separator4);
            this.Name = "FarmPanelUserControl";
            this.Size = new System.Drawing.Size(452, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
		public System.Windows.Forms.FlowLayoutPanel flowPanel;
		public System.Windows.Forms.Label FarmName;
	}
}
