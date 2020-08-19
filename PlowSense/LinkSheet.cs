using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlowSense.Models;
using SheetToObjects.Adapters.GoogleSheets;
using SheetToObjects.Lib;
using SheetToObjects.Lib.FluentConfiguration;

namespace PlowSense
{
	public partial class LinkSheet : Form
	{
		public string sheetID;
		public LinkSheet()
		{
			InitializeComponent();
		}

		private void LinkSheet_Load(object sender, EventArgs e)
		{
			sheetID = string.Empty;
		}

		private async void okBtn_Click(object sender, EventArgs e)
		{
			sheetID = txtBoxSheetID.Text;
			SheetMapper sheetmapper = new SheetMapper().AddConfigFor<TransactionHistory>(cfg 
				=> cfg.MapColumn(column => column.WithHeader("Crop").IsRequired().MapTo(t => t.Crop))
					.MapColumn(column => column.WithHeader("Farm Representative").IsRequired().MapTo(t => t.FarmRep))
					.MapColumn(column => column.WithHeader("Amount Sold").IsRequired().MapTo(t => t.AmountSold)))
				.AddConfigFor<MonthlyHarvest>(cfg => cfg.MapColumn(column => column.WithHeader("Crop").IsRequired().MapTo(m => m.Crop))
					.MapColumn(column => column.WithHeader("Amount Harvested").IsRequired().MapTo(m => m.AmountHarvest)));
			
			GoogleSheetAdapter adapter = new GoogleSheetAdapter();

			Task<Sheet> transactionSheet = adapter.GetAsync(sheetID, "'Transaction History'!A1:ZZ", "AIzaSyCkssJLOPN-8WdM3HX_8N3kdq62_9hn_wA");
			Task<Sheet> harvestSheet = adapter.GetAsync(sheetID,
				"'Monthly Harvest'!A1:ZZ", "AIzaSyCkssJLOPN-8WdM3HX_8N3kdq62_9hn_wA");

			await Task.WhenAll(transactionSheet, harvestSheet);

			List<TransactionHistory> tranInfo = sheetmapper.Map<TransactionHistory>(transactionSheet.Result)
				.ParsedModels
				.Select(o => o.Value).ToList();
			List<DateTime> transDates = transactionSheet.Result.Rows.Where(o => DateTime.TryParse((string)o.Cells[0].Value, out _) && o.Cells.Count != 1)
				.Select(o => DateTime.Parse((string)o.Cells[0].Value)).ToList();

			List<MonthlyHarvest> monthlyHvstsInfo = sheetmapper.Map<MonthlyHarvest>(harvestSheet.Result)
				.ParsedModels
				.Select(o => o.Value).ToList();
			List<DateTime> monthDates = harvestSheet.Result.Rows.Where(o => DateTime.TryParse((string)o.Cells[0].Value, out _) && o.Cells.Count != 1)
				.Select(o => DateTime.Parse((string)o.Cells[0].Value)).ToList();

			MainForm.monthlyharvests = Enumerable.Range(0, monthDates.Count)
				.ToDictionary(i => monthDates[i], i => monthlyHvstsInfo[i]);
			MainForm.transactions = Enumerable.Range(0, transDates.Count)
				.ToDictionary(i => transDates[i], i => tranInfo[i]);
			this.Close();
		}
	}
}
