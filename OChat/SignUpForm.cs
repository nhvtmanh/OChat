using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace OChat
{
    public partial class SignUpForm : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private string avatarPath;

        public SignUpForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.BackColor = ColorTranslator.FromHtml("#ffffff");
            this.btnSignUp.BackColor = ColorTranslator.FromHtml("#42b72a");
            this.btnSignUp.ForeColor = ColorTranslator.FromHtml("#ffffff");
            this.btnSignUp.FlatStyle = FlatStyle.Flat;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnLogIn.BackColor = ColorTranslator.FromHtml("#2563eb");
            this.btnLogIn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            this.btnLogIn.FlatStyle = FlatStyle.Flat;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.BackColor = ColorTranslator.FromHtml("#FFA52C");
            this.btnUploadImage.ForeColor = ColorTranslator.FromHtml("#ffffff");
            this.btnUploadImage.FlatStyle = FlatStyle.Flat;
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
        }

        public event EventHandler SignUp
        {
            add { btnSignUp.Click += value; }
            remove { btnSignUp.Click -= value; }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"; ;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatarPath = openFileDialog.FileName;
                pbAvatar.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string password = tbPass.Text;

            if (username == "" || phone == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (avatarPath == null)
            {
                MessageBox.Show("Please upload your avatar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidVietnamesePhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveUserDataToFile(username, phone, email, password, avatarPath);
            BackToLogin();
        }

        private void BackToLogin()
        {
            MainStartForm.signUpForm.Visible = false;
            MainStartForm.logInForm.Visible = true;
            MainStartForm.logInForm.FocusTextboxEmail();
        }

        private void SaveUserDataToFile(string username, string phone, string email, string password, string avatarPath)
        {
            string filePath = SharedVariables.fileDataUserPath;

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Determine the last ID used
            int lastId = 0;
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];
                string lastIdStr = lastLine.Split('|')[0];
                int.TryParse(lastIdStr, out lastId);
            }

            // Increment the ID for the new user
            int newId = lastId + 1;

            // Create a string that contains the user data
            string userData = $"{newId}|{username}|{password}|{phone}|{email}|{avatarPath}";

            // Write the user data to the file
            using (StreamWriter sw = new StreamWriter(filePath, true)) // true to append data to the file
            {
                sw.WriteLine(userData);
            }

            MessageBox.Show("Sign up successfully", "Notification", MessageBoxButtons.OK);
        }

        public bool IsValidVietnamesePhoneNumber(string number)
        {
            var pattern = @"^((09(\d){8})|(086(\d){7})|(088(\d){7})|(089(\d){7})|(01(\d){9}))$";
            var regex = new Regex(pattern);
            return regex.IsMatch(number);
        }

        public bool IsValidEmail(string email)
        {
            var pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            BackToLogin();
        }
    }
}
