namespace PlowSense
{
    partial class Staff
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.staffPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.removeBtn = new Guna.UI2.WinForms.Guna2Button();
			this.continueBtn = new Guna.UI2.WinForms.Guna2Button();
			this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.cropCmbBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.taskCmbBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.farmCmbBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.amountTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.nameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.addStaffBtn = new Guna.UI2.WinForms.Guna2Button();
			this.tagLabel = new System.Windows.Forms.Label();
			this.taskDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
			this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.taskDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.TargetControl = this;
			// 
			// staffPanel
			// 
			this.staffPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
			this.staffPanel.Location = new System.Drawing.Point(9, 21);
			this.staffPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.staffPanel.Name = "staffPanel";
			this.staffPanel.Size = new System.Drawing.Size(384, 216);
			this.staffPanel.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.removeBtn);
			this.panel1.Controls.Add(this.continueBtn);
			this.panel1.Controls.Add(this.datePicker);
			this.panel1.Controls.Add(this.cropCmbBox);
			this.panel1.Controls.Add(this.taskCmbBox);
			this.panel1.Controls.Add(this.farmCmbBox);
			this.panel1.Controls.Add(this.amountTxtBox);
			this.panel1.Controls.Add(this.nameTxtBox);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(398, 21);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(505, 324);
			this.panel1.TabIndex = 2;
			// 
			// removeBtn
			// 
			this.removeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.removeBtn.Animated = true;
			this.removeBtn.AutoRoundedCorners = true;
			this.removeBtn.BorderRadius = 14;
			this.removeBtn.CheckedState.Parent = this.removeBtn;
			this.removeBtn.CustomImages.Parent = this.removeBtn;
			this.removeBtn.Enabled = false;
			this.removeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeBtn.ForeColor = System.Drawing.Color.White;
			this.removeBtn.HoverState.Parent = this.removeBtn;
			this.removeBtn.Location = new System.Drawing.Point(128, 291);
			this.removeBtn.Name = "removeBtn";
			this.removeBtn.ShadowDecoration.Parent = this.removeBtn;
			this.removeBtn.Size = new System.Drawing.Size(110, 30);
			this.removeBtn.TabIndex = 37;
			this.removeBtn.Text = "Remove Staff";
			this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
			// 
			// continueBtn
			// 
			this.continueBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.continueBtn.Animated = true;
			this.continueBtn.AutoRoundedCorners = true;
			this.continueBtn.BorderRadius = 14;
			this.continueBtn.CheckedState.Parent = this.continueBtn;
			this.continueBtn.CustomImages.Parent = this.continueBtn;
			this.continueBtn.Enabled = false;
			this.continueBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
			this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.continueBtn.ForeColor = System.Drawing.Color.White;
			this.continueBtn.HoverState.Parent = this.continueBtn;
			this.continueBtn.Location = new System.Drawing.Point(12, 291);
			this.continueBtn.Name = "continueBtn";
			this.continueBtn.ShadowDecoration.Parent = this.continueBtn;
			this.continueBtn.Size = new System.Drawing.Size(110, 30);
			this.continueBtn.TabIndex = 37;
			this.continueBtn.Text = "Continue";
			this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
			// 
			// datePicker
			// 
			this.datePicker.CheckedState.Parent = this.datePicker;
			this.datePicker.Enabled = false;
			this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.datePicker.HoverState.Parent = this.datePicker;
			this.datePicker.Location = new System.Drawing.Point(12, 233);
			this.datePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.datePicker.Name = "datePicker";
			this.datePicker.ShadowDecoration.Parent = this.datePicker;
			this.datePicker.Size = new System.Drawing.Size(180, 29);
			this.datePicker.TabIndex = 3;
			this.datePicker.Value = new System.DateTime(2020, 8, 20, 14, 52, 35, 99);
			// 
			// cropCmbBox
			// 
			this.cropCmbBox.BackColor = System.Drawing.Color.Transparent;
			this.cropCmbBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cropCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cropCmbBox.Enabled = false;
			this.cropCmbBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cropCmbBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cropCmbBox.FocusedState.Parent = this.cropCmbBox;
			this.cropCmbBox.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cropCmbBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cropCmbBox.HoverState.Parent = this.cropCmbBox;
			this.cropCmbBox.ItemHeight = 30;
			this.cropCmbBox.ItemsAppearance.Parent = this.cropCmbBox;
			this.cropCmbBox.Location = new System.Drawing.Point(140, 167);
			this.cropCmbBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cropCmbBox.Name = "cropCmbBox";
			this.cropCmbBox.ShadowDecoration.Parent = this.cropCmbBox;
			this.cropCmbBox.Size = new System.Drawing.Size(125, 36);
			this.cropCmbBox.TabIndex = 2;
			// 
			// taskCmbBox
			// 
			this.taskCmbBox.BackColor = System.Drawing.Color.Transparent;
			this.taskCmbBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.taskCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.taskCmbBox.Enabled = false;
			this.taskCmbBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.taskCmbBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.taskCmbBox.FocusedState.Parent = this.taskCmbBox;
			this.taskCmbBox.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.taskCmbBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.taskCmbBox.HoverState.Parent = this.taskCmbBox;
			this.taskCmbBox.ItemHeight = 30;
			this.taskCmbBox.Items.AddRange(new object[] {
            "Buy",
            "Inventory Check"});
			this.taskCmbBox.ItemsAppearance.Parent = this.taskCmbBox;
			this.taskCmbBox.Location = new System.Drawing.Point(12, 167);
			this.taskCmbBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.taskCmbBox.Name = "taskCmbBox";
			this.taskCmbBox.ShadowDecoration.Parent = this.taskCmbBox;
			this.taskCmbBox.Size = new System.Drawing.Size(114, 36);
			this.taskCmbBox.TabIndex = 2;
			this.taskCmbBox.SelectedIndexChanged += new System.EventHandler(this.taskCmbBox_SelectedIndexChanged);
			// 
			// farmCmbBox
			// 
			this.farmCmbBox.BackColor = System.Drawing.Color.Transparent;
			this.farmCmbBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.farmCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.farmCmbBox.Enabled = false;
			this.farmCmbBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.farmCmbBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.farmCmbBox.FocusedState.Parent = this.farmCmbBox;
			this.farmCmbBox.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.farmCmbBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.farmCmbBox.HoverState.Parent = this.farmCmbBox;
			this.farmCmbBox.ItemHeight = 30;
			this.farmCmbBox.Items.AddRange(new object[] {
            "Bruh",
            "Oof",
            "Aaaa"});
			this.farmCmbBox.ItemsAppearance.Parent = this.farmCmbBox;
			this.farmCmbBox.Location = new System.Drawing.Point(12, 100);
			this.farmCmbBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.farmCmbBox.Name = "farmCmbBox";
			this.farmCmbBox.ShadowDecoration.Parent = this.farmCmbBox;
			this.farmCmbBox.Size = new System.Drawing.Size(151, 36);
			this.farmCmbBox.TabIndex = 2;
			// 
			// amountTxtBox
			// 
			this.amountTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.amountTxtBox.DefaultText = "";
			this.amountTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.amountTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.amountTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.amountTxtBox.DisabledState.Parent = this.amountTxtBox;
			this.amountTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.amountTxtBox.Enabled = false;
			this.amountTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.amountTxtBox.FocusedState.Parent = this.amountTxtBox;
			this.amountTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.amountTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.amountTxtBox.HoverState.Parent = this.amountTxtBox;
			this.amountTxtBox.Location = new System.Drawing.Point(286, 167);
			this.amountTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.amountTxtBox.Name = "amountTxtBox";
			this.amountTxtBox.PasswordChar = '\0';
			this.amountTxtBox.PlaceholderText = "";
			this.amountTxtBox.SelectedText = "";
			this.amountTxtBox.ShadowDecoration.Parent = this.amountTxtBox;
			this.amountTxtBox.Size = new System.Drawing.Size(106, 29);
			this.amountTxtBox.TabIndex = 1;
			// 
			// nameTxtBox
			// 
			this.nameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nameTxtBox.DefaultText = "";
			this.nameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.nameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.nameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.nameTxtBox.DisabledState.Parent = this.nameTxtBox;
			this.nameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.nameTxtBox.Enabled = false;
			this.nameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.nameTxtBox.FocusedState.Parent = this.nameTxtBox;
			this.nameTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.nameTxtBox.HoverState.Parent = this.nameTxtBox;
			this.nameTxtBox.Location = new System.Drawing.Point(12, 37);
			this.nameTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nameTxtBox.Name = "nameTxtBox";
			this.nameTxtBox.PasswordChar = '\0';
			this.nameTxtBox.PlaceholderText = "";
			this.nameTxtBox.SelectedText = "";
			this.nameTxtBox.ShadowDecoration.Parent = this.nameTxtBox;
			this.nameTxtBox.Size = new System.Drawing.Size(220, 29);
			this.nameTxtBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 167);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 18);
			this.label4.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(137, 145);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 18);
			this.label7.TabIndex = 0;
			this.label7.Text = "Crop";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 88);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 18);
			this.label3.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(9, 145);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "Task";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 211);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 18);
			this.label5.TabIndex = 0;
			this.label5.Text = "Date";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(283, 145);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 18);
			this.label8.TabIndex = 0;
			this.label8.Text = "Amount";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 78);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Designated Farm";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Staff Name";
			// 
			// addStaffBtn
			// 
			this.addStaffBtn.Animated = true;
			this.addStaffBtn.AutoRoundedCorners = true;
			this.addStaffBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
			this.addStaffBtn.BorderRadius = 14;
			this.addStaffBtn.BorderThickness = 1;
			this.addStaffBtn.CheckedState.Parent = this.addStaffBtn;
			this.addStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addStaffBtn.CustomImages.Parent = this.addStaffBtn;
			this.addStaffBtn.CustomizableEdges.TopRight = false;
			this.addStaffBtn.FillColor = System.Drawing.Color.Transparent;
			this.addStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStaffBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
			this.addStaffBtn.HoverState.Parent = this.addStaffBtn;
			this.addStaffBtn.Image = global::PlowSense.Properties.Resources.gplus_math_208px;
			this.addStaffBtn.Location = new System.Drawing.Point(231, 236);
			this.addStaffBtn.Name = "addStaffBtn";
			this.addStaffBtn.ShadowDecoration.Parent = this.addStaffBtn;
			this.addStaffBtn.Size = new System.Drawing.Size(161, 31);
			this.addStaffBtn.TabIndex = 36;
			this.addStaffBtn.Text = "Add Staff";
			this.addStaffBtn.Click += new System.EventHandler(this.addStaffBtn_Click);
			// 
			// tagLabel
			// 
			this.tagLabel.AutoSize = true;
			this.tagLabel.Location = new System.Drawing.Point(10, 254);
			this.tagLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.tagLabel.Name = "tagLabel";
			this.tagLabel.Size = new System.Drawing.Size(0, 13);
			this.tagLabel.TabIndex = 37;
			this.tagLabel.Visible = false;
			// 
			// taskDataGrid
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.taskDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.taskDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.taskDataGrid.BackgroundColor = System.Drawing.Color.White;
			this.taskDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.taskDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.taskDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.taskDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.taskDataGrid.ColumnHeadersHeight = 27;
			this.taskDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sName,
            this.Task,
            this.Date});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.taskDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
			this.taskDataGrid.EnableHeadersVisualStyles = false;
			this.taskDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.taskDataGrid.Location = new System.Drawing.Point(9, 362);
			this.taskDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.taskDataGrid.Name = "taskDataGrid";
			this.taskDataGrid.RowHeadersVisible = false;
			this.taskDataGrid.RowHeadersWidth = 51;
			this.taskDataGrid.RowTemplate.Height = 24;
			this.taskDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.taskDataGrid.Size = new System.Drawing.Size(894, 159);
			this.taskDataGrid.TabIndex = 38;
			this.taskDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.taskDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.taskDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.taskDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.taskDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.taskDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.taskDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.taskDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.taskDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.taskDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.taskDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.taskDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.taskDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.taskDataGrid.ThemeStyle.HeaderStyle.Height = 27;
			this.taskDataGrid.ThemeStyle.ReadOnly = false;
			this.taskDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.taskDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.taskDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.taskDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.taskDataGrid.ThemeStyle.RowsStyle.Height = 24;
			this.taskDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.taskDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// sName
			// 
			this.sName.HeaderText = "Name";
			this.sName.MinimumWidth = 6;
			this.sName.Name = "sName";
			this.sName.ReadOnly = true;
			// 
			// Task
			// 
			this.Task.HeaderText = "Task";
			this.Task.MinimumWidth = 6;
			this.Task.Name = "Task";
			this.Task.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.HeaderText = "Date";
			this.Date.MinimumWidth = 6;
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			// 
			// Staff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
			this.ClientSize = new System.Drawing.Size(912, 548);
			this.Controls.Add(this.taskDataGrid);
			this.Controls.Add(this.tagLabel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.addStaffBtn);
			this.Controls.Add(this.staffPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Staff";
			this.Text = "Staff";
			this.Load += new System.EventHandler(this.Staff_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.taskDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.FlowLayoutPanel staffPanel;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Button addStaffBtn;
		private Guna.UI2.WinForms.Guna2TextBox nameTxtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
		private Guna.UI2.WinForms.Guna2ComboBox farmCmbBox;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2ComboBox taskCmbBox;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2ComboBox cropCmbBox;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2TextBox amountTxtBox;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2Button continueBtn;
		private Guna.UI2.WinForms.Guna2Button removeBtn;
		private System.Windows.Forms.Label tagLabel;
		private Guna.UI2.WinForms.Guna2DataGridView taskDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn sName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Task;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
	}
}