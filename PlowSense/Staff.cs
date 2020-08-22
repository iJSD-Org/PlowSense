using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PlowSense.Models;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using ICSharpCode.SharpZipLib.Core;

namespace PlowSense
{
	public partial class Staff : Form
	{
		private int _tag;
		private readonly List<StaffInfo> _staffList = new List<StaffInfo>();

		public Staff()
		{
			InitializeComponent();
		}
		#region P/Invoke
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,
			int nTopRect,
			int nRightRect,
			int nBottomRect,
			int nWidthEllipse,
			int nHeightEllipse
		);
		#endregion
		private void Staff_Load(object sender, EventArgs e)
		{
			LoadComboBoxChoices();
			SetColors();
		}

		void LoadComboBoxChoices()
		{
			foreach (var farm in FarmsForm.Farms)
			{
				farmCmbBox.Items.Add(farm.Farm);
			}

			foreach (var crop in MainForm.MonthlyHarvests.Values.Select(o => o.Crop).Distinct())
			{
				cropCmbBox.Items.Add(crop);
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
			nameTxtBox.Text = string.Empty;
			amountTxtBox.Text = string.Empty;
			farmCmbBox.SelectedItem = string.Empty;
			taskCmbBox.SelectedItem = string.Empty;
			cropCmbBox.SelectedItem = string.Empty;
			amountTxtBox.Text = string.Empty;
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
				s.Task = $"Buy {amountTxtBox.Text} kg of {cropCmbBox.SelectedItem} at" +
						 $" {farmCmbBox.SelectedItem}";
			}
			else
			{
				s.Task = $"Inventory check at {farmCmbBox.SelectedItem}";
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
				BackColor = System.Drawing.Color.White,
				Location = new Point(0, 50),
				ForeColor = Color.White,
				AutoSize = false,
				Size = new Size(80, 80)
			};
			PictureBox staffPic = new PictureBox
			{
				Image = Properties.Resources.staff_96px,
				SizeMode = PictureBoxSizeMode.CenterImage,
				Dock = DockStyle.Fill,
				BackColor = System.Drawing.Color.Transparent
			};
			p.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, p.Width, p.Height, 30, 30));
			p.Click += panel1_Click;
			staffPanel.Controls.Add(p);
			p.Controls.Add(staffPic);
			_tag++;

		}
		private void addStaffBtn_Click(object sender, EventArgs e)
		{
			EnableControls();
		}


		private void panel1_Click(object sender, EventArgs e)
		{
			Panel staff = (Panel)sender;

			nameTxtBox.Text = _staffList[Convert.ToInt32(staff.Tag)].Name;
			removeBtn.Enabled = true;

			tagLabel.Text = staff.Tag.ToString();
		}

		private void continueBtn_Click(object sender, EventArgs e)
		{
			if (nameTxtBox.Text != string.Empty && farmCmbBox.SelectedItem != null
												&& taskCmbBox.SelectedItem != null)
			{
				AddStaff();
				StaffInfo staff = new StaffInfo();
				AddData(staff);

				if (!_staffList.Contains(staff))
				{
					_staffList.Add(staff);
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
			taskDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Proxima Soft", 14, FontStyle.Bold);
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
			if (_staffList.Count != 0)
			{
				foreach (Panel p in staffPanel.Controls)
				{
					if (p.Tag.ToString() == tagLabel.Text)
					{
						staffPanel.Controls.Remove(p);
						_staffList.RemoveAt(Convert.ToInt32(p.Tag));
					}
				}

				DisableControls();
			}
		}
	}
}
