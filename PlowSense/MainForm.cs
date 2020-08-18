using System;
using System.Windows.Forms;

namespace PlowSense
{
	public partial class MainForm : Form
	{

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{

		}

		private void farmsTab_Click(object sender, System.EventArgs e)
		{
			dashBoardPanel.Controls.Clear();
			Farms farms = new Farms { TopLevel = false };
			dashBoardPanel.Controls.Add(farms);
			farms.Show();
		}

		private void statsTab_Click(object sender, System.EventArgs e)
		{
			dashBoardPanel.Controls.Clear();
			Statistics stats = new Statistics { TopLevel = false };
			dashBoardPanel.Controls.Add(stats);
			stats.Show();
		}

		private void staffTab_Click(object sender, System.EventArgs e)
		{
			dashBoardPanel.Controls.Clear();
			Staff staff = new Staff { TopLevel = false };
			dashBoardPanel.Controls.Add(staff);
			staff.Show();
		}
	}
}
