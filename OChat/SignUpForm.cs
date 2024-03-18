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
    public partial class SignUpForm : UserControl
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        public event EventHandler SignUp
        {
            add { btnSignUp.Click += value; }
            remove { btnSignUp.Click -= value; }
        }
    }
}
