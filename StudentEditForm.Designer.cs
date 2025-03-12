using System;
using System.Windows.Forms;

namespace lalari
{
    public partial class StudentEditForm : Form
    {
        private TextBox NameTxt, AgeTxt, AddressTxt, ContactTxt, EmailTxt, GuardianTxt, GuardianContactTxt, HobbiesTxt, NicknameTxt;
        private ComboBox CourseDropdown, YearDropdown;
        private Button SaveButton;

        // Event delegate for updating student profile in StudentForm
        public event Action<string, string, string, string, string, string, string, string, string, string> OnProfileUpdated;



        private void InitializeComponent()
        {
            this.Text = "Edit Student Profile";
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label nameLabel = new Label { Text = "Name:", Location = new System.Drawing.Point(20, 20) };
            NameTxt = new TextBox { Location = new System.Drawing.Point(150, 20), Width = 200 };

            Label ageLabel = new Label { Text = "Age:", Location = new System.Drawing.Point(20, 60) };
            AgeTxt = new TextBox { Location = new System.Drawing.Point(150, 60), Width = 200 };
            AgeTxt.KeyPress += ValidateNumericInput;

            Label addressLabel = new Label { Text = "Address:", Location = new System.Drawing.Point(20, 100) };
            AddressTxt = new TextBox { Location = new System.Drawing.Point(150, 100), Width = 200 };

            Label contactLabel = new Label { Text = "Contact No:", Location = new System.Drawing.Point(20, 140) };
            ContactTxt = new TextBox { Location = new System.Drawing.Point(150, 140), Width = 200 };
            ContactTxt.KeyPress += ValidateNumericInput;

            Label emailLabel = new Label { Text = "Email:", Location = new System.Drawing.Point(20, 180) };
            EmailTxt = new TextBox { Location = new System.Drawing.Point(150, 180), Width = 200 };

            Label guardianLabel = new Label { Text = "Parents:", Location = new System.Drawing.Point(20, 220) };
            GuardianTxt = new TextBox { Location = new System.Drawing.Point(150, 220), Width = 200 };

            Label guardianContactLabel = new Label { Text = "Parents Contact:", Location = new System.Drawing.Point(20, 260) };
            GuardianContactTxt = new TextBox { Location = new System.Drawing.Point(150, 260), Width = 200 };
            GuardianContactTxt.KeyPress += ValidateNumericInput;

            Label courseLabel = new Label { Text = "Course:", Location = new System.Drawing.Point(20, 300) };
            CourseDropdown = new ComboBox { Location = new System.Drawing.Point(150, 300), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            CourseDropdown.Items.AddRange(new string[] { "ABEL", "BSBA", "BSIT", "BPA" });

            Label hobbiesLabel = new Label { Text = "Hobbies:", Location = new System.Drawing.Point(20, 340) };
            HobbiesTxt = new TextBox { Location = new System.Drawing.Point(150, 340), Width = 200 };

            Label nicknameLabel = new Label { Text = "Nickname:", Location = new System.Drawing.Point(20, 380) };
            NicknameTxt = new TextBox { Location = new System.Drawing.Point(150, 380), Width = 200 };

            SaveButton = new Button { Text = "Save", Location = new System.Drawing.Point(150, 420), Width = 100 };
            SaveButton.Click += SaveButton_Click;

            this.Controls.AddRange(new Control[] {
                nameLabel, NameTxt, ageLabel, AgeTxt, addressLabel, AddressTxt, contactLabel, ContactTxt,
                emailLabel, EmailTxt, guardianLabel, GuardianTxt, guardianContactLabel, GuardianContactTxt,
                courseLabel, CourseDropdown, hobbiesLabel, HobbiesTxt, nicknameLabel, NicknameTxt, SaveButton
            });
        }

        // Method to validate numeric input (only digits allowed)
        private void ValidateNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Save button click event
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Check if any required field is empty
            if (string.IsNullOrWhiteSpace(NameTxt.Text) || string.IsNullOrWhiteSpace(AgeTxt.Text) ||
                string.IsNullOrWhiteSpace(AddressTxt.Text) || string.IsNullOrWhiteSpace(ContactTxt.Text) ||
                string.IsNullOrWhiteSpace(EmailTxt.Text) || string.IsNullOrWhiteSpace(GuardianTxt.Text) ||
                string.IsNullOrWhiteSpace(GuardianContactTxt.Text) || CourseDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Trigger event to update StudentForm
            OnProfileUpdated?.Invoke(
                NameTxt.Text, AgeTxt.Text, AddressTxt.Text, ContactTxt.Text,
                EmailTxt.Text, GuardianTxt.Text, GuardianContactTxt.Text,
                HobbiesTxt.Text, NicknameTxt.Text, CourseDropdown.SelectedItem.ToString()
            );

            MessageBox.Show("Profile successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}