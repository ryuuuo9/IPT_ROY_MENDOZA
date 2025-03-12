using System;
using System.Windows.Forms;

namespace lalari
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox studentImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblName, lblAge, lblAddress, lblContact, lblEmail, lblCourse;
        private System.Windows.Forms.Label lblParent, lblParentContact, lblHobbies, lblNickname;


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
            this.components = new System.ComponentModel.Container();
            this.Text = "Student Profile";
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Student Image
            studentImage = new System.Windows.Forms.PictureBox();
            studentImage.Size = new System.Drawing.Size(120, 120);
            studentImage.Location = new System.Drawing.Point(190, 20);
            studentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            studentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // Add Image Button
            btnAddImage = new System.Windows.Forms.Button();
            btnAddImage.Text = "Add/Change Image";
            btnAddImage.Size = new System.Drawing.Size(150, 30);
            btnAddImage.Location = new System.Drawing.Point(175, 150);

            // Edit Button
            btnEdit = new System.Windows.Forms.Button();
            btnEdit.Text = "Edit Profile";
            btnEdit.Size = new System.Drawing.Size(150, 30);
            btnEdit.Location = new System.Drawing.Point(175, 490);
            btnEdit.Click += BtnEdit_Click;

            // Labels
            lblName = CreateLabel("Name: ROy S. MENDOZA", 50, 200);
            lblAge = CreateLabel("Age: 20", 50, 230);
            lblAddress = CreateLabel("Address: MAIGPA, BAYAMBANG, PANGASINAN", 50, 260);
            lblContact = CreateLabel("Contact: 09166601335", 50, 290);
            lblEmail = CreateLabel("Email: ryu@gmail.com", 50, 320);
            lblCourse = CreateLabel("Course: BSIT WMT 3-2", 50, 350);
            lblParent = CreateLabel("Parent: SOLIDAD S. MENDOZA", 50, 380);
            lblParentContact = CreateLabel("Parent Contact: 09987654321", 50, 410);
            lblHobbies = CreateLabel("Hobbies: Coding, DRAWING", 50, 440);
            lblNickname = CreateLabel("Nickname: Ryu", 50, 470);

            // Add Controls
            this.Controls.Add(studentImage);
            this.Controls.Add(btnAddImage);
            this.Controls.Add(lblName);
            this.Controls.Add(lblAge);
            this.Controls.Add(lblAddress);
            this.Controls.Add(lblContact);
            this.Controls.Add(lblEmail);
            this.Controls.Add(lblCourse);
            this.Controls.Add(lblParent);
            this.Controls.Add(lblParentContact);
            this.Controls.Add(lblHobbies);
            this.Controls.Add(lblNickname);
            this.Controls.Add(btnEdit);
        }

        private System.Windows.Forms.Label CreateLabel(string text, int x, int y)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Text = text;
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Arial", 12);
            label.Location = new System.Drawing.Point(x, y);
            return label;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            StudentEditForm editForm = new StudentEditForm();

            // Subscribe to the event
            editForm.OnProfileUpdated += (name, age, address, contact, email, guardian, guardianContact, hobbies, nickname, course) =>
            {
                lblName.Text = "Name: " + name;
                lblAge.Text = "Age: " + age;
                lblAddress.Text = "Address: " + address;
                lblContact.Text = "Contact: " + contact;
                lblEmail.Text = "Email: " + email;
                lblParent.Text = "Parent: " + guardian;
                lblParentContact.Text = "Parent Contact: " + guardianContact;
                lblHobbies.Text = "Hobbies: " + hobbies;
                lblNickname.Text = "Nickname: " + nickname;
                lblCourse.Text = "Course: " + course;
            };

            editForm.ShowDialog();
        }
    }
}