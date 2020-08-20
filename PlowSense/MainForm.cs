using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
			Statistics statistics = new Statistics()
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
			Farms farms = new Farms
			{
				MdiParent = this,
				Parent = dashboardTabControl.TabPages[0]
			};
			farms.Show();
		}

		private void farmsTab_Click(object sender, EventArgs e)
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

		private void statsTab_Click(object sender, EventArgs e)
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

		private void staffTab_Click(object sender, EventArgs e)
		{
			dashboardTabControl.SelectedIndex = 2;
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
