﻿namespace PlowSense
{
	partial class AddFarmForm
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
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.LocationText = new Guna.UI2.WinForms.Guna2TextBox();
            this.addCropPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShelfLifeText = new Guna.UI2.WinForms.Guna2TextBox();
            this.CropText = new Guna.UI2.WinForms.Guna2TextBox();
            this.CropsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CropsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.addCropBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.addCropPanel.SuspendLayout();
            this.CropsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.CropsPanel;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 40);
            this.panel1.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Add a Farm";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(359, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.NameText);
            this.guna2Panel1.Controls.Add(this.LocationText);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 52);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(376, 144);
            this.guna2Panel1.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Farm Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Farm Owner:";
            // 
            // NameText
            // 
            this.NameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameText.DefaultText = "Enter Farmer Name";
            this.NameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.DisabledState.Parent = this.NameText;
            this.NameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.FocusedState.Parent = this.NameText;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.HoverState.Parent = this.NameText;
            this.NameText.Location = new System.Drawing.Point(9, 33);
            this.NameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.PlaceholderText = "";
            this.NameText.SelectedText = "";
            this.NameText.SelectionStart = 17;
            this.NameText.ShadowDecoration.Parent = this.NameText;
            this.NameText.Size = new System.Drawing.Size(363, 36);
            this.NameText.TabIndex = 5;
            this.NameText.Enter += new System.EventHandler(this.NameText_Enter);
            // 
            // LocationText
            // 
            this.LocationText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LocationText.DefaultText = "Enter Location";
            this.LocationText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LocationText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LocationText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LocationText.DisabledState.Parent = this.LocationText;
            this.LocationText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LocationText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LocationText.FocusedState.Parent = this.LocationText;
            this.LocationText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LocationText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LocationText.HoverState.Parent = this.LocationText;
            this.LocationText.Location = new System.Drawing.Point(7, 95);
            this.LocationText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LocationText.Name = "LocationText";
            this.LocationText.PasswordChar = '\0';
            this.LocationText.PlaceholderText = "";
            this.LocationText.SelectedText = "";
            this.LocationText.SelectionStart = 14;
            this.LocationText.ShadowDecoration.Parent = this.LocationText;
            this.LocationText.Size = new System.Drawing.Size(365, 36);
            this.LocationText.TabIndex = 6;
            this.LocationText.Enter += new System.EventHandler(this.LocationText_Enter);
            // 
            // addCropPanel
            // 
            this.addCropPanel.BackColor = System.Drawing.Color.White;
            this.addCropPanel.Controls.Add(this.label5);
            this.addCropPanel.Controls.Add(this.label4);
            this.addCropPanel.Controls.Add(this.ShelfLifeText);
            this.addCropPanel.Controls.Add(this.CropText);
            this.addCropPanel.Controls.Add(this.addCropBtn);
            this.addCropPanel.Location = new System.Drawing.Point(13, 343);
            this.addCropPanel.Name = "addCropPanel";
            this.addCropPanel.ShadowDecoration.Parent = this.addCropPanel;
            this.addCropPanel.Size = new System.Drawing.Size(376, 151);
            this.addCropPanel.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(5, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Shelf Life:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(5, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Crop Name:";
            // 
            // ShelfLifeText
            // 
            this.ShelfLifeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShelfLifeText.DefaultText = "Enter Crop Shelf Life";
            this.ShelfLifeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ShelfLifeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ShelfLifeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ShelfLifeText.DisabledState.Parent = this.ShelfLifeText;
            this.ShelfLifeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ShelfLifeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShelfLifeText.FocusedState.Parent = this.ShelfLifeText;
            this.ShelfLifeText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShelfLifeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShelfLifeText.HoverState.Parent = this.ShelfLifeText;
            this.ShelfLifeText.Location = new System.Drawing.Point(9, 92);
            this.ShelfLifeText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShelfLifeText.Name = "ShelfLifeText";
            this.ShelfLifeText.PasswordChar = '\0';
            this.ShelfLifeText.PlaceholderText = "";
            this.ShelfLifeText.SelectedText = "";
            this.ShelfLifeText.SelectionStart = 21;
            this.ShelfLifeText.ShadowDecoration.Parent = this.ShelfLifeText;
            this.ShelfLifeText.Size = new System.Drawing.Size(259, 36);
            this.ShelfLifeText.TabIndex = 37;
            this.ShelfLifeText.Enter += new System.EventHandler(this.ShelfLifeText_Enter);
            // 
            // CropText
            // 
            this.CropText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CropText.DefaultText = "Enter Crop Name";
            this.CropText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CropText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CropText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CropText.DisabledState.Parent = this.CropText;
            this.CropText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CropText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CropText.FocusedState.Parent = this.CropText;
            this.CropText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CropText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CropText.HoverState.Parent = this.CropText;
            this.CropText.Location = new System.Drawing.Point(9, 30);
            this.CropText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CropText.Name = "CropText";
            this.CropText.PasswordChar = '\0';
            this.CropText.PlaceholderText = "";
            this.CropText.SelectedText = "";
            this.CropText.SelectionStart = 15;
            this.CropText.ShadowDecoration.Parent = this.CropText;
            this.CropText.Size = new System.Drawing.Size(259, 36);
            this.CropText.TabIndex = 36;
            this.CropText.Enter += new System.EventHandler(this.CropText_Enter);
            // 
            // CropsPanel
            // 
            this.CropsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(151)))), ((int)(((byte)(77)))));
            this.CropsPanel.BorderRadius = 20;
            this.CropsPanel.Controls.Add(this.CropsFlowPanel);
            this.CropsPanel.Location = new System.Drawing.Point(12, 227);
            this.CropsPanel.Name = "CropsPanel";
            this.CropsPanel.ShadowDecoration.Parent = this.CropsPanel;
            this.CropsPanel.Size = new System.Drawing.Size(376, 110);
            this.CropsPanel.TabIndex = 40;
            // 
            // CropsFlowPanel
            // 
            this.CropsFlowPanel.AutoScroll = true;
            this.CropsFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(151)))), ((int)(((byte)(77)))));
            this.CropsFlowPanel.Location = new System.Drawing.Point(3, 5);
            this.CropsFlowPanel.Name = "CropsFlowPanel";
            this.CropsFlowPanel.Size = new System.Drawing.Size(370, 100);
            this.CropsFlowPanel.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(7, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Select Crops";
            // 
            // addCropBtn
            // 
            this.addCropBtn.Animated = true;
            this.addCropBtn.CheckedState.Parent = this.addCropBtn;
            this.addCropBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCropBtn.CustomImages.Parent = this.addCropBtn;
            this.addCropBtn.FillColor = System.Drawing.Color.Transparent;
            this.addCropBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCropBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
            this.addCropBtn.HoverState.Parent = this.addCropBtn;
            this.addCropBtn.Image = global::PlowSense.Properties.Resources.gplus_math_208px;
            this.addCropBtn.ImageOffset = new System.Drawing.Point(0, 3);
            this.addCropBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.addCropBtn.Location = new System.Drawing.Point(274, 19);
            this.addCropBtn.Name = "addCropBtn";
            this.addCropBtn.ShadowDecoration.Parent = this.addCropBtn;
            this.addCropBtn.Size = new System.Drawing.Size(85, 100);
            this.addCropBtn.TabIndex = 35;
            this.addCropBtn.Text = "Add Crop";
            this.addCropBtn.TextOffset = new System.Drawing.Point(0, 5);
            this.addCropBtn.Click += new System.EventHandler(this.addCropBtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // AddFarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.addCropPanel);
            this.Controls.Add(this.CropsPanel);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFarmForm";
            this.Text = "AddFarmForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.addCropPanel.ResumeLayout(false);
            this.addCropPanel.PerformLayout();
            this.CropsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox NameText;
		private Guna.UI2.WinForms.Guna2TextBox LocationText;
		private Guna.UI2.WinForms.Guna2Panel addCropPanel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox ShelfLifeText;
		private Guna.UI2.WinForms.Guna2TextBox CropText;
		private Guna.UI2.WinForms.Guna2Button addCropBtn;
		private Guna.UI2.WinForms.Guna2Panel CropsPanel;
		private System.Windows.Forms.FlowLayoutPanel CropsFlowPanel;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
	}
}