using System;
using System.Windows.Forms;

namespace PlowSense
{
	public partial class SignUpForm : Form
	{
		public string Username { get; set; }
		public string Password { get; set; }

		public SignUpForm()
		{
			InitializeComponent();
		}

		private void exitImageButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void signUpTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Check for spaces
			if (e.KeyChar == 32) e.Handled = true;
		}

		private void signUpTextBox_TextChanged(object sender, EventArgs e)
		{
			enterButton.Enabled = usernameTextBox.Text != string.Empty && passTextBox.Text != string.Empty &&
								  confirmPassTextBox.Text != string.Empty && passTextBox.Text == confirmPassTextBox.Text;
		}

		private void enterButton_Click(object sender, EventArgs e)
		{
			Username = usernameTextBox.Text;
			Password = passTextBox.Text;
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
