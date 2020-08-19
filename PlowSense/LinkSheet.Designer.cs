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
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 13;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtBoxSheetID
            // 
            this.txtBoxSheetID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSheetID.DefaultText = "";
            this.txtBoxSheetID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSheetID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSheetID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSheetID.DisabledState.Parent = this.txtBoxSheetID;
            this.txtBoxSheetID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSheetID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSheetID.FocusedState.Parent = this.txtBoxSheetID;
            this.txtBoxSheetID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxSheetID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSheetID.HoverState.Parent = this.txtBoxSheetID;
            this.txtBoxSheetID.Location = new System.Drawing.Point(77, 121);
            this.txtBoxSheetID.Name = "txtBoxSheetID";
            this.txtBoxSheetID.PasswordChar = '\0';
            this.txtBoxSheetID.PlaceholderText = "";
            this.txtBoxSheetID.SelectedText = "";
            this.txtBoxSheetID.ShadowDecoration.Parent = this.txtBoxSheetID;
            this.txtBoxSheetID.Size = new System.Drawing.Size(200, 36);
            this.txtBoxSheetID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Proxima Soft Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter your sheetID";
            // 
            // okBtn
            // 
            this.okBtn.CheckedState.Parent = this.okBtn;
            this.okBtn.CustomImages.Parent = this.okBtn;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.HoverState.Parent = this.okBtn;
            this.okBtn.Location = new System.Drawing.Point(147, 196);
            this.okBtn.Name = "okBtn";
            this.okBtn.ShadowDecoration.Parent = this.okBtn;
            this.okBtn.Size = new System.Drawing.Size(51, 45);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // LinkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 403);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSheetID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LinkSheet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LinkSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2TextBox txtBoxSheetID;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Button okBtn;
	}
}