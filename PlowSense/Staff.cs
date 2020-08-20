using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using PlowSense.Models;
using FontStyle = System.Windows.FontStyle;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace PlowSense
{
	public partial class Staff : Form
	{
		private int _tag = 0;
		private List<StaffInfo> staffList = new List<StaffInfo>();

		public Staff()
		{
			InitializeComponent();
		}

		private void Staff_Load(object sender, EventArgs e)
		{
			LoadOptions();
			SetColors();
		}

		void LoadOptions()
		{
			foreach (var item in MainForm.Transactions.Values.GroupBy(o => o.Crop))
			{
				cropCmbBox.Items.Add(item.Key);
			}
		}

		void EnableControls()
		{
			nameTxtBox.Enabled = true;
			amountTxtBox.Enabled = true;
			farmCmbBox.Enabled = true;
			taskCmbBox.Enabled = true;
			datePicker.Enabled = true;
			continueBtn.Enabled = true;
			removeBtn.Enabled = true;
		}

		void DisableControls()
		{
			nameTxtBox.Enabled = false;
			amountTxtBox.Enabled = false;
			farmCmbBox.Enabled = false;
			taskCmbBox.Enabled = false;
			datePicker.Enabled = false;
			cropCmbBox.Enabled = false;
			amountTxtBox.Enabled = false;
			continueBtn.Enabled = false;
			removeBtn.Enabled = false;
		}

		void AddData(StaffInfo s)
		{
			s.Name = nameTxtBox.Text;
			s.AssignedFarm = farmCmbBox.SelectedItem.ToString();
			if (taskCmbBox.SelectedItem.ToString() == "Buy")
			{
				s.Task = $"Buy {amountTxtBox.Text} kg of {cropCmbBox.SelectedItem.ToString()} at" +
				         $" {farmCmbBox.SelectedItem.ToString()}";
			}
			else
			{
				s.Task = $"Inventory check at {farmCmbBox.SelectedItem.ToString()}";
			}

			s.Deadline = datePicker.Value;
		}

		void UpdateTable(StaffInfo s)
		{
			taskDataGrid.Rows.Add(s.Name, s.Task, s.Deadline.ToString("MM/dd/yyyy"));
		}

		void AddStaff()
		{
			Panel p = new Panel
			{
				Tag = _tag,
				BackColor = System.Drawing.Color.FromArgb(222, 205, 5),
				Location = new Point(0, 50),
				ForeColor = System.Drawing.Color.White,
				AutoSize = false,
				Size = new Size(80, 95)
			};

			p.Click += new EventHandler(panel1_Click);
			staffPanel.Controls.Add(p);
			_tag++;

		}
		private void addStaffBtn_Click(object sender, EventArgs e)
		{
			EnableControls();
		}


		private void panel1_Click(object sender, EventArgs e)
		{
			Panel staff = (Panel) sender;
			try
			{
				nameTxtBox.Text = staffList[Convert.ToInt32(staff.Tag)].Name;
				removeBtn.Enabled = true;
			}
			catch
			{

			}
			tagLabel.Text = staff.Tag.ToString();

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void continueBtn_Click(object sender, EventArgs e)
		{
			if (nameTxtBox.Text != string.Empty && farmCmbBox.SelectedItem != null
			                                    && taskCmbBox.SelectedItem != null)
			{
				AddStaff();
				StaffInfo staff = new StaffInfo();
				AddData(staff);

				if (!staffList.Contains(staff))
				{
					staffList.Add(staff);
				}


				UpdateTable(staff);
				DisableControls();
			}
			else
			{
				CustomMessageBox msBox = new CustomMessageBox("Error", 
					"Please complete the details first!", CustomMessageBoxStatus.Alert);
				msBox.ShowDialog();
			}

		}

		void SetColors()
		{
			taskDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(9, 105, 54);
			taskDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Proxima Soft", 14, System.Drawing.FontStyle.Bold);
			taskDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 231, 76);
			taskDataGrid.GridColor = Color.White;
			taskDataGrid.DefaultCellStyle.SelectionBackColor = Color.LightGray;
			taskDataGrid.Font = new Font("Proxima Soft", 11);
		}
		private void taskCmbBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (taskCmbBox.SelectedItem.ToString() == "Buy")
			{
				cropCmbBox.Enabled = true;
				amountTxtBox.Enabled = true;
			}
			else
			{
				cropCmbBox.Enabled = false;
				amountTxtBox.Enabled = false;
			}
		}

		private void removeBtn_Click(object sender, EventArgs e)
		{
			if (staffList.Count != 0)
			{
				foreach (Panel p in staffPanel.Controls)
				{
					if (p.Tag.ToString() == tagLabel.Text)
					{
						staffPanel.Controls.Remove(p);
						staffList.RemoveAt(Convert.ToInt32(p.Tag));
					}
				}

				DisableControls();
			}
		}
	}
}
