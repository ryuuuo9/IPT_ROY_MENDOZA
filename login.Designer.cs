namespace lalari
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.Button LoginBtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();

            // Form Properties
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Text = "Login Form";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Username TextBox
            this.UsernameTxt.Location = new System.Drawing.Point(50, 50);
            this.UsernameTxt.Size = new System.Drawing.Size(250, 30);
            this.UsernameTxt.Font = new System.Drawing.Font("Arial", 12);
            this.UsernameTxt.ForeColor = System.Drawing.Color.Gray;
            this.UsernameTxt.Text = "Username";
            this.UsernameTxt.GotFocus += RemoveUsernamePlaceholder;
            this.UsernameTxt.LostFocus += AddUsernamePlaceholder;

            // Password TextBox
            this.PasswordTxt.Location = new System.Drawing.Point(50, 100);
            this.PasswordTxt.Size = new System.Drawing.Size(250, 30);
            this.PasswordTxt.Font = new System.Drawing.Font("Arial", 12);
            this.PasswordTxt.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTxt.Text = "Password";
            this.PasswordTxt.PasswordChar = '\0'; // Ensure placeholder is visible
            this.PasswordTxt.GotFocus += RemovePasswordPlaceholder;
            this.PasswordTxt.LostFocus += AddPasswordPlaceholder;

            // Error Label
            this.ErrorLbl.Location = new System.Drawing.Point(50, 180);
            this.ErrorLbl.Size = new System.Drawing.Size(250, 30);
            this.ErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrorLbl.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.ErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLbl.Visible = false;

            // Login Button
            this.LoginBtn.Location = new System.Drawing.Point(50, 140);
            this.LoginBtn.Size = new System.Drawing.Size(250, 40);
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);

            // Add Controls to Form
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.LoginBtn);
        }
    }
}