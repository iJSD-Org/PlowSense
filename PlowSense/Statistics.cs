using System;
using System.Windows.Media;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace PlowSense
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
		BrushConverter converter = new System.Windows.Media.BrushConverter();
		Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{1:P}", chartpoint.Y, chartpoint.Participation);
		private void Statistics_Load(object sender, EventArgs e)
		{
			PieLoad();
		}
		void LineLoad()
		{
			statsChart.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Line 1",
					Values = new ChartValues<int> {61, 63, 37, 62, 67, 75, 45, 52, 54, 45},
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(80,9, 105, 54)),
					PointGeometry = null,
					LineSmoothness = 100,
					Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(9, 105, 54))
				},
			};
			List<string> l = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
			statsChart.AxisX.Add(new Axis
			{
				Title = "X",
				Labels = l
			});
			statsChart.AxisY.Add(new Axis
			{
				Title = "Y",
				MinValue = 0
			});
		}
		void PieLoad()
		{
			statsPie.Series= new SeriesCollection
			{
				new PieSeries
				{
					Title = "Title 1",
					Values = new ChartValues<double> {100},
					Fill = (System.Windows.Media.Brush)converter.ConvertFromString("#9CE74C"),
					DataLabels = true,
					LabelPoint = labelPoint,
					StrokeThickness = 0,
				},
				new PieSeries
				{
					Title = "Title 2",
					Values = new ChartValues<double> {300},
					Fill = (System.Windows.Media.Brush)converter.ConvertFromString("#DECD05"),
					DataLabels = true,
					LabelPoint = labelPoint,
					StrokeThickness = 0
				},
				new PieSeries
				{
					Title = "Title 3",
					Values = new ChartValues<double> {250},
					Fill = (System.Windows.Media.Brush)converter.ConvertFromString("#BBB324"),
					DataLabels = true,
					LabelPoint = labelPoint,
					StrokeThickness = 0
				},
			};
			DefaultLegend customLegend = new DefaultLegend();
			customLegend.BulletSize = 10;
			customLegend.Foreground = System.Windows.Media.Brushes.White;
			customLegend.FontSize = 15;
			statsPie.DefaultLegend = customLegend;
			statsPie.LegendLocation = LegendLocation.Right;
		}
	}
}
