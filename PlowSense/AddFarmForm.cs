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
			if (!string.IsNullOrWhiteSpace(CropText.Text) && !string.IsNullOrWhiteSpace(ShelfLifeText.Text))
			{
				#region Create Crop Item Panel
				Panel p = new Panel
				{
					BackColor = System.Drawing.Color.FromArgb(180, 9, 105, 54),
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
					ForeColor = Color.White,
					BackColor = Color.Transparent
				};
				p.Controls.Add(name);
				var cropImage = Properties.Resources.natural_food_80px;
				if (CropText.Text.ToLower() == "potato") cropImage = Properties.Resources.potato_80px;
				if (CropText.Text.ToLower() == "carrot") cropImage = Properties.Resources.carrot_80px;
				if (CropText.Text.ToLower() == "apple") cropImage = Properties.Resources.apple_80px;
				if (CropText.Text.ToLower() == "onion") cropImage = Properties.Resources.onion_80px;
				if (CropText.Text.ToLower() == "garlic") cropImage = Properties.Resources.garlic_80px;
				if (CropText.Text.ToLower() == "tomato") cropImage = Properties.Resources.tomato_80px;
				if (CropText.Text.ToLower() == "rice") cropImage = Properties.Resources.rice_bowl_80px;
				if (CropText.Text.ToLower() == "wheat") cropImage = Properties.Resources.wheat_80px;
				if (CropText.Text.ToLower() == "bell pepper") cropImage = Properties.Resources.paprika_80px;
				PictureBox cropPic = new PictureBox
				{
					Image = cropImage,
					SizeMode = PictureBoxSizeMode.StretchImage,
					Size = new Size(70, 70),
					Location = new Point(5, 10),
					BackColor = System.Drawing.Color.Transparent
				};
				#endregion

				p.Controls.Add(cropPic);
				p.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, p.Width, p.Height, 20, 20));

				List<CropInfo> selectedFarmCrops = FarmsForm.Farms.First(f => f.Farm == farmNameText.Text).Crops;
				selectedFarmCrops.Add(new CropInfo { Crop = CropText.Text, Farm = farmNameText.Text, ShelfLife = ShelfLifeText.Text });
				confirmBtn.Enabled = true;
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
			if (!string.IsNullOrWhiteSpace(NameText.Text) && !string.IsNullOrWhiteSpace(LocationText.Text) && !string.IsNullOrWhiteSpace(farmNameText.Text))
			{
				confirmFarmerInfBtn.Enabled = NameText.Enabled = LocationText.Enabled = farmNameText.Enabled = false;
				CropText.Enabled = ShelfLifeText.Enabled = addCropBtn.Enabled = true;
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
