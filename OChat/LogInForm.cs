using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OChat
{
    public partial class LogInForm : UserControl
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

        private Form parentForm;

        public LogInForm(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
            DoubleBuffered = true;
            ResizeRedraw = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            BackColor = ColorTranslator.FromHtml("#ffffff");
            btnLogIn.BackColor = ColorTranslator.FromHtml("#2563eb");
            btnLogIn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnSignUp.BackColor = ColorTranslator.FromHtml("#42b72a");
            btnSignUp.ForeColor = ColorTranslator.FromHtml("#ffffff");
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.FlatAppearance.BorderSize = 0;

            UpdateUIBaseOnLanguage();
        }

        private void UpdateUIBaseOnLanguage()
        {
            if (Properties.Settings.Default.isEN)
            {
                lbLogin.Text = "Login";
                lbPass.Text = "Password";
                btnLogIn.Text = "Log in";
                btnSignUp.Text = "Sign up";
                btnForgetPass.Text = "Forgotten password";
            }
            else
            {
                lbLogin.Text = "Đăng nhập";
                lbPass.Text = "Mật khẩu";
                btnLogIn.Text = "Đăng nhập";
                btnSignUp.Text = "Đăng ký";
                btnForgetPass.Text = "Quên mật khẩu";

                //fix UI when change Vietnamese language
                lbLogin.Location = new Point(this.Size.Width / 2 - lbLogin.Width / 2, lbLogin.Location.Y);
                btnForgetPass.Location = new Point(this.Size.Width / 2 - btnForgetPass.Width / 2, btnForgetPass.Location.Y);
            }
        }

        public event EventHandler ShowSignUpForm
        {
            add { btnSignUp.Click += value; }
            remove { btnSignUp.Click -= value; }
        }

        public event EventHandler ForgetPassword
        {
            add { btnForgetPass.Click += value; }
            remove { btnForgetPass.Click -= value; }
        }

        public void FocusTextboxEmail()
        {
            this.tbEmail.Focus();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckCredentials(email, password))
            {
                MessageBox.Show("Wrong email or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DisplayMainChatForm();
        }

        private void DisplayMainChatForm()
        {
            this.parentForm.Hide();
            MainChatForm mainChatForm = new MainChatForm();
            mainChatForm.ShowDialog();
            this.parentForm.Close();
        }

        public bool CheckCredentials(string email, string password)
        {
            string filePath = SharedVariables.fileDataUserPath;
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[4] == email && parts[2] == password)
                {
                    SharedVariables.userID = int.Parse(parts[0]);
                    SharedVariables.userAvatarPath = parts[5];
                    SharedVariables.userName = parts[1];
                    return true;
                }
            }
            return false;
        }

        public bool IsValidEmail(string email)
        {
            var pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void btnForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = tbEmail.Text;
            if (email == "")
            {
                MessageBox.Show("Please fill in your email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("21522329@gm.uit.edu.vn");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "gnot ourm irgj radb");
            smtp.Host = "smtp.gmail.com";

            mail.To.Add(new MailAddress(email));
            mail.IsBodyHtml = true;
            mail.Subject = "OChat - Your password here";
            string password = GetUserPassword(email);
            mail.Body = "Your password is: " + password;

            smtp.Send(mail);
            MessageBox.Show("Your password has sent to the registered email. Please check!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetUserPassword(string email)
        {
            string password = "";
            string filePath = SharedVariables.fileDataUserPath;
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[4] == email)
                {
                    password = parts[2];
                    break;
                }
            }
            return password;
        }
    }
}
