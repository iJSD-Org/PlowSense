using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using Ganss.Excel;
using PlowSense.Models;


namespace PlowSense
{
	public partial class FarmsForm : Form
	{
		internal static List<FarmInfo> Farms;
		internal static List<string> FarmOwners = new List<string>();
		private int _selectedPanel;
		private int _tag;
		public FarmsForm()
		{
			InitializeComponent();
			if (File.Exists(@"Spreadsheets\Farms.xlsx"))
				GetFarmExcelData();
			else
				Farms = new List<FarmInfo>();
		}

		private void Farms_Load(object sender, EventArgs e)
		{
			FarmLoad();
			SetScrollBar();
			LoadOwners();
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
			ExcelMapper excelFile = new ExcelMapper(@"Spreadsheets\Farms.xlsx");
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

		void LoadOwners()
		{
			if (Farms.Count != 0)
			{
				foreach (var o in Farms.Select(o => o.FarmRep))
				{
					FarmOwners.Add(o);
				}
				_selectedPanel = 0;
			}
		}

		void LoadCropData()
		{
			amountLabel.Text =
				$"{MainForm.FarmInventories.Where(o => o.FarmRep == FarmOwners[_selectedPanel] && o.Crop == cropCmbBox.SelectedItem.ToString()).Select(o => o.Amount).First()}kg";
			timeLabel.Text =
				$"{MainForm.FarmInventories.Where(o => o.FarmRep == FarmOwners[_selectedPanel] && o.Crop == cropCmbBox.SelectedItem.ToString()).Select(o => o.TimeInStorage).First()}days";
		}
		void FarmLoad()
		{
			foreach (FarmInfo farm in Farms)
			{
				#region Create Farm Panel
				FarmPanelUserControl farmPanel = new FarmPanelUserControl();
				farmPanel.Tag = _tag;
				_tag++;
				farmPanel.Click += FarmPanelUserControl_Click;
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
		void CropLoad()
		{
			cropCmbBox.Items.Clear();
			List<string> availableCrops = new List<string>();
			foreach (var farm in MainForm.MonthlyHarvests.Values.Where(o => o.FarmRep == FarmOwners[_selectedPanel]))
			{
				if (!availableCrops.Contains(farm.Crop))
				{
					availableCrops.Add(farm.Crop);
					cropCmbBox.Items.Add(farm.Crop);
				}
			}

			cropCmbBox.SelectedItem = availableCrops.First();
		}


		void LoadChart1()
		{
			farmChart.Series.Clear();
			farmChart.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = cropCmbBox.SelectedItem.ToString(),
					Values = new ChartValues<int>
						(MainForm.MonthlyHarvests.Values.
						Where(m => m.FarmRep == FarmOwners[Convert.ToInt32(_selectedPanel)])
						.Where(m => m.Crop == cropCmbBox.SelectedItem.ToString()).Select(m => m.AmountHarvest).ToList()),
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(80, 9, 105, 54)),
					PointGeometry = DefaultGeometries.Square,
					LineSmoothness = 100,
					Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(9, 105, 54))
				},
			};
		}

		void LoadChart2()
		{
			farmChart.Series.Clear();
			farmChart.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Income",
					Values = new ChartValues<int>
					(MainForm.Transactions.Values.Where(t => t.FarmRep == FarmOwners[_selectedPanel])
						.Select(t => t.Income).ToList()),
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(80, 9, 105, 54)),
					PointGeometry = DefaultGeometries.Square,
					LineSmoothness = 100,
					Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(9, 105, 54))
				},
			};
		}
		private void FarmPanelUserControl_Click(object o, EventArgs a)
		{
			FarmPanelUserControl p = (FarmPanelUserControl)o;
			_selectedPanel = Convert.ToInt32(p.Tag);
			CropLoad();
			LoadChart1();
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

		private void cropCmbBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadChart1();
			LoadCropData();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			LoadChart1();
			chartLabel.Text = "Monthly Harvest";
			cropCmbBox.Enabled = true;
		}

		private void chart2Btn_Click(object sender, EventArgs e)
		{
			LoadChart2();
			chartLabel.Text = "Monthly Income";
			cropCmbBox.Enabled = false;
		}

		private void myFarmsScroll_Scroll(object sender, ScrollEventArgs e)
		{
			myFarmsFlowPanel.VerticalScroll.Value = myFarmsScroll.Value;
			if (myFarmsFlowPanel.VerticalScroll.Value != myFarmsScroll.Value) myFarmsFlowPanel.VerticalScroll.Value = myFarmsScroll.Value;
		}
	}
}