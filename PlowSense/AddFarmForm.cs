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
		private string _fullEntry = string.Empty;
		private int _tag;

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

		private void addCropBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(CropText.Text) && !string.IsNullOrWhiteSpace(LocationText.Text) && !string.IsNullOrWhiteSpace(farmNameText.Text))
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
				CropsFlowPanel.Controls.Add(p);
				Label name = new Label
				{
					Tag = _tag,
					Font = new Font("Arial", 10),
					Text = CropText.Text,
					Location = new Point(5, 76),
					ForeColor = System.Drawing.Color.White
				};
				p.Controls.Add(name);
				PictureBox reactPic = new PictureBox
				{
					Image = Properties.Resources.wfield_208px,
					SizeMode = PictureBoxSizeMode.AutoSize,
					Location = new Point(3, 3)
				};
				p.Controls.Add(reactPic);
				p.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, p.Width, p.Height, 20, 20));
				_tag++;
				string i = NameText.Text + "," + LocationText.Text + "," + farmNameText.Text + "," + CropText.Text + "," + ShelfLifeText.Text + "\n";
				_fullEntry += i;
			}
		}

		private void confirmBtn_Click(object sender, EventArgs e)
		{
			StreamWriter csvWrite = new StreamWriter(@"D:\FarmsCSV.csv", true);
			csvWrite.WriteLine(_fullEntry);
			csvWrite.Close();
			Close();
		}
	}
}
