using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SheetToObjects.Adapters.GoogleSheets;
using SheetToObjects.Core;
using SheetToObjects.Lib;
using System.Windows.Forms;
using PlowSense.Models;

namespace PlowSense
{
	public partial class MainForm : Form
	{
		internal static Dictionary<DateTime, TransactionHistory> Transactions;
		internal static Dictionary<DateTime, MonthlyHarvest> MonthlyHarvests;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void farmsTab_Click(object sender, EventArgs e)
		{
			dashBoardPanel.Controls.Clear();
			Farms farms = new Farms { TopLevel = false };
			dashBoardPanel.Controls.Add(farms);
			farms.Show();
		}

		private void statsTab_Click(object sender, EventArgs e)
		{
			dashBoardPanel.Controls.Clear();
			Statistics stats = new Statistics { TopLevel = false };
			dashBoardPanel.Controls.Add(stats);
			stats.Show();
		}

		private void staffTab_Click(object sender, EventArgs e)
		{
			dashBoardPanel.Controls.Clear();
			Staff staff = new Staff { TopLevel = false };
			dashBoardPanel.Controls.Add(staff);
			staff.Show();
		}

		private void linkSheetsTab_Click(object sender, EventArgs e)
		{
			LinkSheet sheetForm = new LinkSheet();
			sheetForm.Show();
		}
	}
}
