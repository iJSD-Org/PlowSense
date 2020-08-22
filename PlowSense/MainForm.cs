using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ganss.Excel;
using PlowSense.Models;

namespace PlowSense
{
	public partial class MainForm : Form
	{
		internal static Dictionary<DateTime, TransactionHistory> Transactions = new Dictionary<DateTime, TransactionHistory>();
		internal static Dictionary<DateTime, MonthlyHarvest> MonthlyHarvests = new Dictionary<DateTime, MonthlyHarvest>();
		internal static List<FarmInventory> FarmInventories = new List<FarmInventory>();
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Statistics statistics = new Statistics
			{
				MdiParent = this,
				Parent = dashboardTabControl.TabPages[1]
			};
			statistics.Show();
			Staff staff = new Staff
			{
				MdiParent = this,
				Parent = dashboardTabControl.TabPages[2]
			};
			staff.Show();
			FarmsForm farms = new FarmsForm
			{
				MdiParent = this,
				Parent = dashboardTabControl.TabPages[0]
			};
			farms.Show();
		}

		private void farmsTileButton_Click(object sender, EventArgs e)
		{
			if (Transactions.Count != 0)
			{
				dashboardTabControl.SelectedIndex = 0;
			}
			else
			{
				CustomMessageBox msBox = new CustomMessageBox("No sheetID",
					"Please enter a sheetID first!", CustomMessageBoxStatus.Alert);
				msBox.ShowDialog();
			}
		}

		private void statsTileButton_Click(object sender, EventArgs e)
		{
			if (Transactions.Count != 0)
			{
				dashboardTabControl.SelectedIndex = 1;
			}
			else
			{
				CustomMessageBox msBox = new CustomMessageBox("No sheetID",
					"Please enter a sheetID first!", CustomMessageBoxStatus.Alert);
				msBox.ShowDialog();
			}
		}

		private void staffTileButton_Click(object sender, EventArgs e)
		{
			dashboardTabControl.SelectedIndex = 2;
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void linkSheetsButton_Click(object sender, EventArgs e)
		{
			LinkSheet sheetForm = new LinkSheet();
			sheetForm.ShowDialog();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			List<CropInfo> crops = FarmsForm.Farms.SelectMany(f => f.Crops).ToList();
			if (!File.Exists(@"C:\PlowSenseFiles\Farms.xlsx"))
			{
				File.Create(@"C:\PlowSenseFiles\Farms.xlsx").Dispose();
			}
			ExcelMapper excelFile = new ExcelMapper();
			excelFile.Save(@"C:\PlowSenseFiles\Farms.xlsx", FarmsForm.Farms);
			excelFile.Save(@"C:\PlowSenseFiles\Farms.xlsx", crops, 1);
		}
	}
}
