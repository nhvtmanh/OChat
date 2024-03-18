using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OChat
{
    public partial class MainStartForm : Form
    {
        private static LogInForm logInForm;
        private static SignUpForm signUpForm;

        public MainStartForm()
        {
            InitializeComponent();
        }

        private void LoadMainStartForm(object sender, EventArgs e)
        {
            logInForm = new LogInForm();
            logInForm.Location = new Point(117, 41);
            logInForm.ShowSignUpForm += btnSignUp_Click;
            logInForm.LogIn += btnLogIn_Click;
            logInForm.ForgetPassword += btnForgetPass_Click;

            signUpForm = new SignUpForm();
            signUpForm.Location = new Point(117, 41);
            signUpForm.SignUp += SignUp;
            signUpForm.Visible = false;

            this.Controls.Add(logInForm);
            this.Controls.Add(signUpForm);
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

        private void SignUp(object sender, EventArgs e)
        {
            MessageBox.Show("SignUp");
        }
    }
}
