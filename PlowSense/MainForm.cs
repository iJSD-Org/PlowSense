using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SheetToObjects.Adapters.GoogleSheets;
using SheetToObjects.Core;
using SheetToObjects.Lib;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using PlowSense.Models;

namespace PlowSense
{
	public partial class MainForm : Form
	{
		internal static Dictionary<DateTime, TransactionHistory> Transactions = new Dictionary<DateTime, TransactionHistory>();
		internal static Dictionary<DateTime, MonthlyHarvest> MonthlyHarvests = new Dictionary<DateTime, MonthlyHarvest>();

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
			if (MainForm.Transactions.Count != 0)
			{
				Farms farms = new Farms { TopLevel = false };
				dashBoardPanel.Controls.Add(farms);
				farms.Show();
			}
			else MessageBox.Show("Enter a sheetID first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void statsTab_Click(object sender, EventArgs e)
		{
			if (MainForm.Transactions.Count != 0)
			{
				dashBoardPanel.Controls.Clear();
				Statistics stats = new Statistics { TopLevel = false };
				dashBoardPanel.Controls.Add(stats);
				stats.Show();
			}
			else MessageBox.Show("Enter a sheetID first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void staffTab_Click(object sender, EventArgs e)
		{
			dashBoardPanel.Controls.Clear();
			Staff staff = new Staff { TopLevel = false };
			dashBoardPanel.Controls.Add(staff);
			staff.Show();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void linkSheetsTab_Click(object sender, EventArgs e)
		{
			LinkSheet sheetForm = new LinkSheet();
			sheetForm.ShowDialog();
		}

	}
}
