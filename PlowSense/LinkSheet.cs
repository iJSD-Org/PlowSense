using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
		public string SheetId;

		public LinkSheet()
		{
			InitializeComponent();
		}

		private void LinkSheet_Load(object sender, EventArgs e)
		{
			txtBoxSheetID.BackColor = Color.FromArgb(217, 234, 211);
			SheetId = string.Empty;
		}

		private async void okBtn_Click(object sender, EventArgs e)
		{
			okBtn.Enabled = false;
			SheetId = txtBoxSheetID.Text;
			SheetMapper sheetMapper = new SheetMapper().AddConfigFor<TransactionHistory>(cfg
					=> cfg.MapColumn(column => column.WithHeader("Crop").IsRequired().MapTo(t => t.Crop))
						.MapColumn(
							column => column.WithHeader("Farm Representative").IsRequired().MapTo(t => t.FarmRep))
						.MapColumn(column => column.WithHeader("Amount Sold").IsRequired().MapTo(t => t.AmountSold))
						.MapColumn(column => column.WithHeader("Income").IsRequired().MapTo(t => t.Income)))
				.AddConfigFor<MonthlyHarvest>(cfg => cfg
					.MapColumn(column => column.WithHeader("Crop").IsRequired().MapTo(m => m.Crop))
					.MapColumn(column =>
						column.WithHeader("Amount Harvested").IsRequired().MapTo(m => m.AmountHarvest))
					.MapColumn(column => column.WithHeader("Farm Representative").IsRequired().MapTo(o => o.FarmRep)))
				.AddConfigFor<FarmInventory>(cfg => cfg
					.MapColumn(c => c.WithHeader("Crop").IsRequired().MapTo(o => o.Crop))
					.MapColumn(c => c.WithHeader("Amount in Storage").IsRequired().MapTo(o => o.Amount))
					.MapColumn(c => c.WithHeader("Time in Storage").IsRequired().MapTo(o => o.TimeInStorage))
					.MapColumn(c => c.WithHeader("Farm Representative").IsRequired().MapTo(o => o.FarmRep)));

			GoogleSheetAdapter adapter = new GoogleSheetAdapter();

			try
			{
				Task<Sheet> transactionSheet = adapter.GetAsync(SheetId, "'Transaction History'!A1:ZZ",
					"AIzaSyCkssJLOPN-8WdM3HX_8N3kdq62_9hn_wA");
				Task<Sheet> harvestSheet = adapter.GetAsync(SheetId,
					"'Monthly Harvest'!A1:ZZ", "AIzaSyCkssJLOPN-8WdM3HX_8N3kdq62_9hn_wA");
				Task<Sheet> inventorySheet = adapter.GetAsync(SheetId,
					"'Farm Inventory'!A1:ZZ", "AIzaSyCkssJLOPN-8WdM3HX_8N3kdq62_9hn_wA");

				await Task.WhenAll(transactionSheet, harvestSheet, inventorySheet);

				List<TransactionHistory> tranInfo = sheetMapper.Map<TransactionHistory>(transactionSheet.Result)
					.ParsedModels
					.Select(o => o.Value).OrderBy(o => o.Crop).ToList();
				List<DateTime> transDates = transactionSheet.Result.Rows
					.Where(o => DateTime.TryParse((string)o.Cells[0].Value, out _) && o.Cells.Count != 1)
					.Select(o => DateTime.Parse((string)o.Cells[0].Value)).ToList();

				List<MonthlyHarvest> monthlyHarvestsInfo = sheetMapper.Map<MonthlyHarvest>(harvestSheet.Result)
					.ParsedModels
					.Select(o => o.Value).ToList();
				List<DateTime> monthDates = harvestSheet.Result.Rows
					.Where(o => DateTime.TryParse((string)o.Cells[0].Value, out _) && o.Cells.Count != 1)
					.Select(o => DateTime.Parse((string)o.Cells[0].Value)).ToList();

				MainForm.MonthlyHarvests = Enumerable.Range(0, monthDates.Count)
					.ToDictionary(i => monthDates[i], i => monthlyHarvestsInfo[i]);
				MainForm.Transactions = Enumerable.Range(0, transDates.Count)
					.ToDictionary(i => transDates[i], i => tranInfo[i]);

				MainForm.FarmInventories = sheetMapper.Map<FarmInventory>(inventorySheet.Result)
						.ParsedModels
						.Select(o => o.Value).ToList();

			}

			catch
			{
				CustomMessageBox msBox = new CustomMessageBox("Error",
					"Please enter a valid sheetID!", CustomMessageBoxStatus.Cross);
				msBox.ShowDialog();
				okBtn.Enabled = true;
				return;
			}

			CustomMessageBox msSuccessBox = new CustomMessageBox("Success!",
				"Connected to sheet", CustomMessageBoxStatus.Check);
			msSuccessBox.ShowDialog();
			okBtn.Enabled = true;
			Close();
		}
	}
}
