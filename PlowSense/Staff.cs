using System;
using System.Windows;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace PlowSense
{
	public partial class Staff : Form
	{
		private int _tag = 0;

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
				Tag = _tag,
				BackColor = System.Drawing.Color.FromArgb(222, 205, 5),
				Location = new Point(0, 50),
				ForeColor = System.Drawing.Color.White,
				AutoSize = false,
				Size = new Size(80, 95)
			};

			p.Click += new System.EventHandler(panel1_Click);
			flowLayoutPanel1.Controls.Add(p);
			_tag++;
		}

		
		private void panel1_Click(object sender, EventArgs e)
		{
			Panel staff = (Panel) sender;
			
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
