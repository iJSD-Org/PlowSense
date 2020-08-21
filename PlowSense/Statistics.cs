using System;
using System.Windows.Media;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using PlowSense.Models;
using Brush = System.Windows.Media.Brush;
using Brushes = System.Windows.Media.Brushes;
using Color = System.Drawing.Color;

namespace PlowSense
{
	public partial class Statistics : Form
	{
		private readonly BrushConverter _converter = new BrushConverter();
		private readonly Func<ChartPoint, string> _labelPoint = chartPoint => $"{chartPoint.Participation:P}";

		public Statistics()
		{
			InitializeComponent();
		}

		private void Statistics_Load(object sender, EventArgs e)
		{
			SetColors();
			PieLoad();
			CropsLoad();
		}

		void SetColors()
		{
			statsDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(9, 105, 54);
			statsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Proxima Soft", 14, FontStyle.Bold);
			statsDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 231, 76);
			statsDataGrid.GridColor = Color.White;
			statsDataGrid.DefaultCellStyle.SelectionBackColor = Color.LightGray;
			statsDataGrid.Font = new Font("Proxima Soft", 11);
			
		}

		void PieLoad()
		{
			statsPie.Series = new SeriesCollection
			{
				new PieSeries
				{
					Title = "Title 1",
					Values = new ChartValues<double> {100},
					Fill = (Brush)_converter.ConvertFromString("#096936"),
					DataLabels = true,
					LabelPoint = _labelPoint,
					StrokeThickness = 0,
				},
				new PieSeries
				{
					Title = "Title 2",
					Values = new ChartValues<double> {300},
					Fill = (Brush)_converter.ConvertFromString("#71AA85"),
					DataLabels = true,
					LabelPoint = _labelPoint,
					StrokeThickness = 0
				},
				new PieSeries
				{
					Title = "Title 3",
					Values = new ChartValues<double> {250},
					Fill = (Brush)_converter.ConvertFromString("#A5CAAC"),
					DataLabels = true,
					LabelPoint = _labelPoint,
					StrokeThickness = 0
				},
			};
			DefaultLegend customLegend = new DefaultLegend { BulletSize = 10, Foreground = Brushes.White, FontSize = 15 };
			statsPie.DefaultLegend = customLegend;
			statsPie.LegendLocation = LegendLocation.Right;
		}

		void CropsLoad()
		{
			List<string> availableCrops = new List<string>();
			foreach (var farm in MainForm.Transactions.Values)
			{
				if (!availableCrops.Contains(farm.Crop))
				{
					availableCrops.Add(farm.Crop);
					statsCmbBox.Items.Add(farm.Crop);
				}
			}
		}

		void GenerateChartData(Dictionary<DateTime, TransactionHistory> values)
		{
			//Create filtered dictionary
			statsChart.Series.Clear();
			statsChart.AxisX.Clear();

			//Add new values and labels
			statsChart.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = statsCmbBox.SelectedItem.ToString(),
					Values = new ChartValues<int>(values.Values.Select(o => o.AmountSold)),
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(80, 9, 105, 54)),
					PointGeometry = DefaultGeometries.Square,
					LineSmoothness = 100,
					Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(9, 105, 54))
				},
			};

			statsChart.AxisX.Add(new Axis
			{
				Title = "Month",
				Labels = values.Keys.Select(a => a.ToString("MM/dd/yyyy")).ToList()
			});
		}

		void GenerateTableData(Dictionary<DateTime, TransactionHistory> values)
		{
			statsDataGrid.Rows.Clear();
			foreach (var item in values)
			{
				statsDataGrid.Rows.Add(item.Key.ToString("MM/dd/yyyy"),
					item.Value.FarmRep, item.Value.Crop, item.Value.AmountSold);
			}
		}
		
		private void statsCmbBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Dictionary<DateTime, TransactionHistory> filteredValues = MainForm.Transactions
				.Where(o => o.Value.Crop == statsCmbBox.SelectedItem.ToString())
				.ToDictionary(x => x.Key, x => x.Value);

			GenerateChartData(filteredValues);
			GenerateTableData(filteredValues);
		}

		private void statsPie_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{

		}

		private void statsChart_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{

		}
	}
}
