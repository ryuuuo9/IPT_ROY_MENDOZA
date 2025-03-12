using System;
using System.Windows.Forms;

namespace lalari
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Text;

            if (username == "Username" || string.IsNullOrWhiteSpace(username) ||
                password == "Password" || string.IsNullOrWhiteSpace(password))
            {
                ErrorLbl.Text = "Please enter username and password.";
                ErrorLbl.Visible = true;
            }
            else if (username != "roy")
            {
                ErrorLbl.Text = "Incorrect username.";
                ErrorLbl.Visible = true;
            }
            else if (password != "123")
            {
                ErrorLbl.Text = "Incorrect password.";
                ErrorLbl.Visible = true;
            }
            else
            {
                // Successful login
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();
            }
        }

        private void RemoveUsernamePlaceholder(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "Username")
            {
                UsernameTxt.Text = "";
                UsernameTxt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void AddUsernamePlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTxt.Text))
            {
                UsernameTxt.Text = "Username";
                UsernameTxt.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void RemovePasswordPlaceholder(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "Password")
            {
                PasswordTxt.Text = "";
                PasswordTxt.PasswordChar = '●';
                PasswordTxt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void AddPasswordPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTxt.Text))
            {
                PasswordTxt.PasswordChar = '\0';
                PasswordTxt.Text = "Password";
                PasswordTxt.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
