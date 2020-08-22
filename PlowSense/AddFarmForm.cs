using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Documents;
using PlowSense.Models;

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

		private void farmNameText_Enter(object sender, EventArgs e)
		{
			BeginInvoke((Action)delegate
			{
				farmNameText.SelectAll();
			});
		}
		private void addCropBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(CropText.Text) && !string.IsNullOrWhiteSpace(LocationText.Text) && !string.IsNullOrWhiteSpace(farmNameText.Text) && !string.IsNullOrWhiteSpace(CropText.Text) && !string.IsNullOrWhiteSpace(ShelfLifeText.Text))
			{
				#region Create Crop Item Panel
				Panel p = new Panel
				{
					BackColor = Color.FromArgb(222, 205, 5),
					Location = new Point(0, 50),
					ForeColor = Color.White,
					AutoSize = false,
					Size = new Size(80, 95)
				};
				CropsFlowPanel.Controls.Add(p);
				Label name = new Label
				{
					Font = new Font("Arial", 10),
					Text = CropText.Text,
					Location = new Point(5, 76),
					ForeColor = Color.White
				};
				p.Controls.Add(name);
				PictureBox cropPic = new PictureBox
				{
					Image = Properties.Resources.wfield_208px,
					SizeMode = PictureBoxSizeMode.AutoSize,
					Location = new Point(3, 3)
				};
				#endregion

				p.Controls.Add(cropPic);
				p.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, p.Width, p.Height, 20, 20));

				List<CropInfo> selectedFarmCrops = FarmsForm.Farms.First(f => f.Farm == farmNameText.Text).Crops;
				selectedFarmCrops.Add(new CropInfo { Crop = CropText.Text, Farm = farmNameText.Text, ShelfLife = ShelfLifeText.Text });
			}
			else
			{
				CustomMessageBox msBox = new CustomMessageBox("Warning",
					"Please fill out all spaces!", CustomMessageBoxStatus.Alert);
				msBox.ShowDialog();
			}
		}

		private void confirmBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void confirmFarmerInfBtn_Click(object sender, EventArgs e)
		{

			if (!string.IsNullOrWhiteSpace(CropText.Text) && !string.IsNullOrWhiteSpace(LocationText.Text) && !string.IsNullOrWhiteSpace(farmNameText.Text))
			{
				confirmFarmerInfBtn.Enabled = false;
				NameText.Enabled = false;
				LocationText.Enabled = false;
				farmNameText.Enabled = false;

				FarmsForm.Farms.Add(new FarmInfo { Crops = new List<CropInfo>(), Farm = farmNameText.Text, FarmRep = NameText.Text, Location = LocationText.Text });
			}
			else
			{
				CustomMessageBox msBox = new CustomMessageBox("Warning",
					"Please fill out all spaces!", CustomMessageBoxStatus.Alert);
				msBox.ShowDialog();
			}
		}
	}
}
