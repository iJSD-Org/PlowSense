using System;
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

namespace PlowSense
{
	public partial class Farms : Form
	{
		public Farms()
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
		private void Farms_Load(object sender, EventArgs e)
		{
			FarmLoad();
			LineLoad();
		}
		int tag = 0;
		void FarmLoad()
		{
			string folderPath = null;
			string directory = null;
			if (Directory.Exists("D:\\"))
			{
				folderPath = "D:\\";
				directory = Path.Combine(folderPath, "PlowSenseFiles");
			}
			else if (Directory.Exists("C:\\"))
			{
				folderPath = "C:\\";
				directory = Path.Combine(folderPath, "PlowSenseFiles");
			}
			System.IO.Directory.CreateDirectory(directory);
			string path = directory + "\\FarmsCSV.csv";
			if (!File.Exists(path)) File.Create(path);
			StreamReader csvReader = new StreamReader(path);
			while (csvReader.Peek() != -1)
			{
				string entryString = csvReader.ReadLine();
				string[] entry = entryString.Split(',');
				int cTag = 0;
				Panel p = new Panel
				{
					Tag = tag,
					BackColor = System.Drawing.Color.FromArgb(9, 105, 54),
					Size = new Size(452, 150),
					ForeColor = System.Drawing.Color.White,
					AutoSize = false,
				};
				Label name = new Label
				{
					Tag = tag,
					Font = new Font("Arial", 18),
					Text = entry[2],
					Location = new Point(10, 15),
					ForeColor = System.Drawing.Color.White,
					AutoSize = true
				};
				p.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, p.Width, p.Height, 30, 30));
				FlowLayoutPanel fp = new FlowLayoutPanel
				{
					Tag = tag,
					BackColor = System.Drawing.Color.FromArgb(196, 222, 186),
					Location = new Point(10, 45),
					Size = new Size(430, 120),
					ForeColor = System.Drawing.Color.White,
					AutoSize = false,
					AutoScroll = true,
					WrapContents = false,
				};
				fp.VerticalScroll.Enabled = false;
				fp.VerticalScroll.Visible = false;
				fp.HorizontalScroll.Visible = false;
				fp.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, fp.Width, fp.Height, 30, 30));
				myFarmsFlowPanel.Controls.Add(p);
				p.Controls.Add(name);
				p.Controls.Add(fp);
				string fileName = directory + "\\N" + entry[0] + "L" + entry[1] + "FN" + entry[2] + ".csv";
				StreamReader cropinfo = new StreamReader(@fileName);
				while (cropinfo.Peek() != -1)
				{
					string cEntryString = cropinfo.ReadLine();
					string[] cEntry = cEntryString.Split(',');
					Panel cp = new Panel
					{
						Tag = cTag,
						BackColor = System.Drawing.Color.FromArgb(222, 205, 5),
						Location = new Point(0, 50),
						ForeColor = System.Drawing.Color.White,
						AutoSize = false,
						Size = new Size(80, 95),
					};
					cp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cp.Width, cp.Height, 20, 20));
					PictureBox cropPic = new PictureBox
					{
						Image = Properties.Resources.wfield_208px,
						SizeMode = PictureBoxSizeMode.StretchImage,
						Size = new Size(70, 70),
						Location = new Point(5, 10)
					};
					Label nName = new Label
					{
						Tag = cTag,
						Font = new Font("Arial", 10, FontStyle.Bold),
						Text = cEntry[3],
						Location = new Point(3, 78),
						ForeColor = System.Drawing.Color.White,
						AutoSize = true
					};
					fp.Controls.Add(cp);
					cp.Controls.Add(cropPic);
					cp.Controls.Add(nName);
					cTag++;
				}
				cropinfo.Close();
				tag++;
			}
			csvReader.Close();
		} 
		void LineLoad()
		{
			List<string> l = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
			farmChart.AxisX.Add(new Axis
			{
				Title = "X",
				Labels = l
			});
			farmChart.AxisY.Add(new Axis
			{
				Title = "Y",
				MinValue = 0
			});
			farmChartOneBtn.Checked = true;
		}
		private void farmChartOneBtn_CheckedChanged(object sender, EventArgs e)
		{
			if (farmChartOneBtn.Checked)
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
			}
		}

		private void farmChartTwoBtn_CheckedChanged(object sender, EventArgs e)
		{
			if (farmChartTwoBtn.Checked)
			{
				farmChart.Series = new SeriesCollection
				{
					new LineSeries
					{
						Title = "Line 1",
						Values = new ChartValues<int> {54, 67, 87, 34, 54, 57, 67, 58, 76, 66},
						Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(80,9, 105, 54)),
						PointGeometry = null,
						LineSmoothness = 100,
						Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(9, 105, 54))
					},
				};
			}
		}

		private void farmChartThreeBtn_CheckedChanged(object sender, EventArgs e)
		{
			if (farmChartThreeBtn.Checked)
			{
				farmChart.Series = new SeriesCollection
				{
					new LineSeries
					{
						Title = "Line 1",
						Values = new ChartValues<int> {71, 53, 47, 82, 47, 55, 75, 62, 56, 76},
						Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(80,9, 105, 54)),
						PointGeometry = null,
						LineSmoothness = 100,
						Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(9, 105, 54))
					},
				};
			}
		}
		private void addFarmBtn_Click(object sender, EventArgs e)
		{
			AddFarmForm addFarmForm = new AddFarmForm();
			addFarmForm.Show();
		} 
		private void refreshBtn_Click(object sender, EventArgs e)
		{
			this.Refresh();
		}
	}
}
