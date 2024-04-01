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
        }

        public event EventHandler SignUp
        {
            add { btnSignUp.Click += value; }
            remove { btnSignUp.Click -= value; }
        }
    }
}
