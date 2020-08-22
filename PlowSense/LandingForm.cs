using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using PlowSense.Models;

namespace PlowSense
{
	public sealed partial class LandingForm : Form
	{
		private readonly List<UserInfo> _userInfos;

		public LandingForm()
		{
			InitializeComponent();
			//Prepare to paint backgroundImage
			DoubleBuffered = true;
			SetStyle(ControlStyles.ResizeRedraw, true);

			//Deserialize UserInfos
			_userInfos = File.Exists("userInfos.json") ? JsonConvert.DeserializeObject<List<UserInfo>>(File.ReadAllText("userInfos.json")) : new List<UserInfo>();

		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
			var rc = new Rectangle(ClientSize.Width - Properties.Resources.landscape_png_95_images_in_collection_page_2_landscape_png_1024_232.Width + 100,
				ClientSize.Height - Properties.Resources.landscape_png_95_images_in_collection_page_2_landscape_png_1024_232.Height,
				Properties.Resources.landscape_png_95_images_in_collection_page_2_landscape_png_1024_232.Width, Properties.Resources.landscape_png_95_images_in_collection_page_2_landscape_png_1024_232.Height);
			e.Graphics.DrawImage(Properties.Resources.landscape_png_95_images_in_collection_page_2_landscape_png_1024_232, rc);
		}

		private void passwordTextBox_IconRightClick(object sender, EventArgs e)
		{
			if (passwordTextBox.PasswordChar == '*')
			{
				passwordTextBox.PasswordChar = '\0';
				passwordTextBox.IconRight = Properties.Resources.icons8_eye_512px;

			}
			else
			{
				passwordTextBox.PasswordChar = '*';
				passwordTextBox.IconRight = Properties.Resources.icons8_hide_512px;
			}
		}

		private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Take a screen shot of the form and darken it
			Bitmap bmp = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
				g.CopyFromScreen(PointToScreen(new Point(0, 0)), new Point(0, 0), ClientRectangle.Size);
				double percent = 0.60;
				Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
				using (Brush brush = new SolidBrush(darken))
				{
					g.FillRectangle(brush, ClientRectangle);
				}
			}
			// Put the darkened screen shot into a Panel and bring it to the front
			// Panel will dispose after form is closed
			using (Panel p = new Panel())
			{
				p.Location = new Point(0, 0);
				p.Size = ClientRectangle.Size;
				p.BackgroundImage = bmp;
				Controls.Add(p);
				p.BringToFront();

				// Display dialog
				SignUpForm signUpForm = new SignUpForm();
				while (signUpForm.ShowDialog(this) == DialogResult.OK)
				{
					if (_userInfos.Any(i => i.Username == signUpForm.Username))
					{
						new CustomMessageBox("Username already exists!", "Please try again", CustomMessageBoxStatus.Alert).ShowDialog();
					}
					else
					{
						_userInfos.Add(new UserInfo { Username = signUpForm.Username, Password = signUpForm.Password });
						new CustomMessageBox("Success", "Account successfully registered!", CustomMessageBoxStatus.Check).ShowDialog();
						break;
					}
				}
			}
		}

		private void exitImageButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Check for space
			if (e.KeyChar == 32) e.Handled = true;
		}

		private void LandingForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			File.WriteAllText("userInfos.json", JsonConvert.SerializeObject(_userInfos));
		}

		private void loginTextBox_TextChanged(object sender, EventArgs e)
		{
			loginButton.Enabled = usernameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty;
		}

		private void loginButton_Click(object sender, EventArgs e)
		{

			Bitmap bmp = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
				g.CopyFromScreen(PointToScreen(new Point(0, 0)), new Point(0, 0), ClientRectangle.Size);
				double percent = 0.60;
				Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
				using (Brush brush = new SolidBrush(darken))
				{
					g.FillRectangle(brush, ClientRectangle);
				}
			}
			// Put the darkened screen shot into a Panel and bring it to the front
			// Panel will dispose after form is closed
			using (Panel p = new Panel())
			{
				p.Location = new Point(0, 0);
				p.Size = ClientRectangle.Size;
				p.BackgroundImage = bmp;
				Controls.Add(p);
				p.BringToFront();

				// Display dialog
				if (_userInfos.Any(i => i.Username == usernameTextBox.Text && i.Password == passwordTextBox.Text))
				{
					new CustomMessageBox("Success", "Login successful!", CustomMessageBoxStatus.Check).ShowDialog();
					//Temporary, should switch to WinForms
					Close();
				}
				else
				{
					new CustomMessageBox("Fail", "Incorrect password or username.", CustomMessageBoxStatus.Cross).ShowDialog();
				}
			}
		}
	}
}
