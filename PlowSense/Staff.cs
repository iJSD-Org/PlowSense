using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace PlowSense
{
	public partial class Staff : Form
	{

		public Staff()
		{
			InitializeComponent();
		}

		private void Staff_Load(object sender, EventArgs e)
		{

		}

		private void addStaffBtn_Click(object sender, EventArgs e)
		{
			Panel p = new Panel
			{
				Tag = $"{guna2TextBox1.Text},{guna2TextBox2.Text},{guna2TextBox3.Text},",
				BackColor = System.Drawing.Color.FromArgb(222, 205, 5),
				Location = new Point(0, 50),
				ForeColor = System.Drawing.Color.White,
				AutoSize = false,
				Size = new Size(80, 95)
			};

			p.Click += new EventHandler(panel1_Click);
			flowLayoutPanel1.Controls.Add(p);
		}


		
		private void panel1_Click(object sender, EventArgs e)
		{
			Panel staff = (Panel) sender;
			string[] values = staff.Tag.ToString().Split(',');
			guna2TextBox1.Text = values[0];
			guna2TextBox2.Text = values[1];
			guna2TextBox3.Text = values[2];
			guna2TextBox1.Enabled = false;
			guna2TextBox2.Enabled = false;
			guna2TextBox3.Enabled = false;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2TextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{

		}
	}
}
