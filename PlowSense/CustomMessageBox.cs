using System;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace PlowSense
{
	public enum CustomMessageBoxStatus
	{
		Check, Cross, Alert
	}

	public partial class CustomMessageBox : Form
	{

		public CustomMessageBox(string title, string desc, CustomMessageBoxStatus icon)
		{
			InitializeComponent();

			titleLabel.Text = title;
			descLabel.Text = desc;
			switch (icon)
			{
				case CustomMessageBoxStatus.Check:
					iconPictureBox.Image = Properties.Resources.Check;
					continueButton.FillColor = Color.FromArgb(118, 164, 62);
					break;
				case CustomMessageBoxStatus.Cross:
					iconPictureBox.Image = Properties.Resources.Cross;
					continueButton.FillColor = Color.FromArgb(255, 89, 60);
					break;
				case CustomMessageBoxStatus.Alert:
					iconPictureBox.Image = Properties.Resources.Alert;
					continueButton.FillColor = Color.FromArgb(254, 191, 24);
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(icon), icon, null);
			}
		}

		private void gifAnimationTimer_Tick(object sender, EventArgs e)
		{
			iconPictureBox.Enabled = false;
			gifAnimationTimer.Stop();
		}

		private void continueButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
