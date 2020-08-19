using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Drawing;

namespace PlowSense
{
	public partial class Farms : Form
	{
		public Farms()
		{
			InitializeComponent();
		}

		private void Farms_Load(object sender, EventArgs e)
		{
			LineLoad();
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
	}
}
