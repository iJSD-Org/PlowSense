using System;
using System.Windows.Media;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Runtime.InteropServices;

namespace PlowSense
{
	public partial class AddFarmForm : Form
	{
		public AddFarmForm()
		{
			InitializeComponent();
		}
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,
			int nTopRect,
			int nRightRect,
			int nBottomRect,
			int nWidthEllipse,
			int nHeightEllipse
		);
		private void NameText_Enter(object sender, EventArgs e)
		{
			BeginInvoke((Action)delegate
			{
				NameText.SelectAll();
			});
		}

		private void LocationText_Enter(object sender, EventArgs e)
		{
			BeginInvoke((Action)delegate
			{
				LocationText.SelectAll();
			});
		}

		private void CropText_Enter(object sender, EventArgs e)
		{
			BeginInvoke((Action)delegate
			{
				CropText.SelectAll();
			});
		}

		private void ShelfLifeText_Enter(object sender, EventArgs e)
		{
			BeginInvoke((Action)delegate
			{
				ShelfLifeText.SelectAll();
			});
		}
		string FullEntry = string.Empty;
		int tag = 0;
		private void addCropBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(CropText.Text) && !string.IsNullOrWhiteSpace(LocationText.Text) && !string.IsNullOrWhiteSpace(farmNameText.Text))
			{
				Panel p = new Panel();
				p.Tag = tag;
				p.BackColor = System.Drawing.Color.FromArgb(222, 205, 5);
				p.Location = new Point(0, 50);
				p.ForeColor = System.Drawing.Color.White;
				p.AutoSize = false;
				p.Size = new Size(80, 95);
				CropsFlowPanel.Controls.Add(p);
				Label name = new Label();
				name.Tag = tag;
				name.Font = new Font("Arial", 10);
				name.Text = CropText.Text;
				name.Location = new Point(5, 76);
				name.ForeColor = System.Drawing.Color.White;
				p.Controls.Add(name);
				PictureBox reacPic = new PictureBox();
				reacPic.Image = PlowSense.Properties.Resources.wfield_208px;
				reacPic.SizeMode = PictureBoxSizeMode.AutoSize;
				reacPic.Location = new Point(3, 3);
				p.Controls.Add(reacPic);
				p.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, p.Width, p.Height, 20, 20));
				tag++;
				string i = NameText.Text + "," + LocationText.Text + "," + farmNameText.Text + "," + CropText.Text + "," + ShelfLifeText.Text + "\n";
				FullEntry += i;
			}
		}

		private void confirmBtn_Click(object sender, EventArgs e)
		{
			StreamWriter CSVWrite = new StreamWriter("D:\\FarmsCSV.csv", true);
			CSVWrite.WriteLine(FullEntry);
			CSVWrite.Close();
			this.Close();
		}
	}
}
