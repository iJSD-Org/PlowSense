﻿using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using Ganss.Excel;
using PlowSense.Models;


namespace PlowSense
{
	public partial class FarmsForm : Form
	{
		internal static List<FarmInfo> Farms;
		public FarmsForm()
		{
			InitializeComponent();
			if (File.Exists(@"D:\PlowSenseFiles\Farms.xlsx"))
			{
				GetFarmExcelData();
			}
			else
			{
				Farms = new List<FarmInfo>();
			}
		}

		private void Farms_Load(object sender, EventArgs e)
		{
			FarmLoad();
			LineLoad();
			SetScrollBar();
		}

		#region P/Invoke
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
		#endregion

		//should be only run once
		private void GetFarmExcelData()
		{
			ExcelMapper excelFile = new ExcelMapper(@"D:\PlowSenseFiles\Farms.xlsx");
			Farms = excelFile.Fetch<FarmInfo>().ToList();
			List<CropInfo> crops = excelFile.Fetch<CropInfo>(1).ToList();
			foreach (FarmInfo farm in Farms)
			{
				farm.Crops = crops.Where(c => c.Farm == farm.Farm).ToList();
			}
		}
		void SetScrollBar()
		{
			myFarmsFlowPanel.AutoScroll = false;
			myFarmsFlowPanel.VerticalScroll.Enabled = false;
			myFarmsFlowPanel.VerticalScroll.Visible = false;
			myFarmsFlowPanel.HorizontalScroll.Enabled = false;
			myFarmsFlowPanel.HorizontalScroll.Visible = false;
			myFarmsFlowPanel.HorizontalScroll.Maximum = 0;
			myFarmsFlowPanel.AutoScroll = true;
			myFarmsScroll.VerticalScroll.Maximum = myFarmsFlowPanel.VerticalScroll.Maximum;
		}
		void FarmLoad()
		{
			foreach (FarmInfo farm in Farms)
			{
				#region Create Farm Panel
				FarmPanelUserControl farmPanel = new FarmPanelUserControl();
				farmPanel.AutoSize = false;
				farmPanel.FarmName.Text = farm.Farm;
				myFarmsFlowPanel.Controls.Add(farmPanel);
				#endregion
				foreach (CropInfo crop in farm.Crops)
				{
					#region Create Crop Panel
					Panel cp = new Panel
					{
						BackColor = System.Drawing.Color.FromArgb(180, 9, 105, 54),
						Location = new Point(0, 50),
						ForeColor = System.Drawing.Color.White,
						AutoSize = false,
						Size = new Size(80, 95),
					};
					cp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cp.Width, cp.Height, 20, 20));
					var cropImage = Properties.Resources.natural_food_80px;
					if (crop.Crop.ToLower() == "potato") cropImage = Properties.Resources.potato_80px;
					if (crop.Crop.ToLower() == "carrot") cropImage = Properties.Resources.carrot_80px;
					if (crop.Crop.ToLower() == "apple") cropImage = Properties.Resources.apple_80px;
					if (crop.Crop.ToLower() == "onion") cropImage = Properties.Resources.onion_80px;
					if (crop.Crop.ToLower() == "garlic") cropImage = Properties.Resources.garlic_80px;
					if (crop.Crop.ToLower() == "tomato") cropImage = Properties.Resources.tomato_80px;
					if (crop.Crop.ToLower() == "rice") cropImage = Properties.Resources.rice_bowl_80px;
					if (crop.Crop.ToLower() == "wheat") cropImage = Properties.Resources.wheat_80px;
					if (crop.Crop.ToLower() == "bell pepper") cropImage = Properties.Resources.paprika_80px;
					PictureBox cropPic = new PictureBox
					{
						Image = cropImage,
						SizeMode = PictureBoxSizeMode.StretchImage,
						Size = new Size(70, 70),
						Location = new Point(5, 10),
						BackColor = System.Drawing.Color.Transparent
					};
					Label nName = new Label
					{
						Font = new Font("Arial", 10, FontStyle.Bold),
						Text = crop.Crop,
						Location = new Point(3, 78),
						ForeColor = System.Drawing.Color.White,
						AutoSize = true,
						BackColor = System.Drawing.Color.Transparent
					};
					#endregion

					farmPanel.flowPanel.Controls.Add(cp);
					cp.Controls.Add(cropPic);
					cp.Controls.Add(nName);
				}
			}
		}

		void LineLoad()
		{
			farmChart.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Line 1",
					Values = new ChartValues<int> {56, 65, 77, 52, 65, 45, 35, 62, 74, 65},
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(80,9, 105, 54)),
					PointGeometry = null,
					LineSmoothness = 100,
					Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(9, 105, 54))
				},
			};
			List<string> l = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
			farmChart.AxisX.Add(new Axis
			{
				Labels = l
			});
			farmChart.AxisY.Add(new Axis
			{
				MinValue = 0
			});
		}

		private void addFarmBtn_Click(object sender, EventArgs e)
		{
			AddFarmForm addFarmForm = new AddFarmForm();
			addFarmForm.ShowDialog();
		}
		private void refreshBtn_Click(object sender, EventArgs e)
		{
			myFarmsFlowPanel.Controls.Clear();
			FarmLoad();
		}

		private void myFarmsScroll_Scroll(object sender, ScrollEventArgs e)
		{
			myFarmsFlowPanel.VerticalScroll.Value = myFarmsScroll.Value;
			if (myFarmsFlowPanel.VerticalScroll.Value != myFarmsScroll.Value) myFarmsFlowPanel.VerticalScroll.Value = myFarmsScroll.Value;
		}

	}
}