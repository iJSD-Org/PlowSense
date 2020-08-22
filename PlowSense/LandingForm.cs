using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlowSense
{
	public sealed partial class LandingForm : Form
	{
		public LandingForm()
		{
			InitializeComponent();
			//Prepare to paint backgroundImage
			DoubleBuffered = true;
			SetStyle(ControlStyles.ResizeRedraw, true);
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
			using (Panel p = new Panel())
			{
				p.Location = new Point(0, 0);
				p.Size = ClientRectangle.Size;
				p.BackgroundImage = bmp;
				Controls.Add(p);
				p.BringToFront();

				// Display dialog
				SignUpForm signUpForm = new SignUpForm();
				signUpForm.ShowDialog(this);
			}
		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
