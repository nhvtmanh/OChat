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

        public LogInForm()
        {
            InitializeComponent();
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
