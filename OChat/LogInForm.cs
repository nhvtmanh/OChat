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
    public partial class LogInForm : UserControl
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        public event EventHandler ShowSignUpForm
        {
            add { btnSignUp.Click += value; }
            remove { btnSignUp.Click -= value; }
        }

        public event EventHandler LogIn
        {
            add { btnLogIn.Click += value; }
            remove { btnLogIn.Click -= value; }
        }

        public event EventHandler ForgetPassword
        {
            add { btnForgetPass.Click += value; }
            remove { btnForgetPass.Click -= value; }
        }
    }
}
