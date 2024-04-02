using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OChat
{
    public partial class MainStartForm : Form
    {
        public static LogInForm logInForm;
        public static SignUpForm signUpForm;

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

        public MainStartForm()
        {
            InitializeComponent();
            LoadMainStartForm();
            this.Shown += new EventHandler(MyForm_Shown);
            DoubleBuffered = true;
            ResizeRedraw = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            BackColor = ColorTranslator.FromHtml("#dbeafe");
        }

        private void MyForm_Shown(object sender, EventArgs e)
        {
            logInForm.FocusTextboxEmail();
        }

        private void LoadMainStartForm()
        {
            logInForm = new LogInForm();
            logInForm.Location = new Point(ClientSize.Width / 2 - logInForm.Size.Width / 2, ClientSize.Height / 2 - logInForm.Size.Height / 2);
            logInForm.ShowSignUpForm += btnSignUp_Click;
            logInForm.LogIn += btnLogIn_Click;
            logInForm.ForgetPassword += btnForgetPass_Click;

            signUpForm = new SignUpForm();
            signUpForm.Location = new Point(ClientSize.Width / 2 - signUpForm.Size.Width / 2, ClientSize.Height / 2 - signUpForm.Size.Height / 2 + 30);
            signUpForm.Visible = false;

            Controls.Add(logInForm);
            Controls.Add(signUpForm);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signUpForm.Visible = true;
            logInForm.Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LogIn");
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ForgetPassword");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
