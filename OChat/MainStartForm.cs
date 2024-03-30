using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = ColorTranslator.FromHtml("#dbeafe");
        }

        private void LoadMainStartForm(object sender, EventArgs e)
        {
            logInForm = new LogInForm();
            logInForm.Location = new Point(ClientSize.Width / 2 - logInForm.Size.Width / 2, ClientSize.Height / 2 - logInForm.Size.Height / 2);
            logInForm.ShowSignUpForm += btnSignUp_Click;
            logInForm.LogIn += btnLogIn_Click;
            logInForm.ForgetPassword += btnForgetPass_Click;

            signUpForm = new SignUpForm();
            signUpForm.Location = new Point(ClientSize.Width / 2 - signUpForm.Size.Width / 2, ClientSize.Height / 2 - signUpForm.Size.Height / 2 + 40);
            signUpForm.SignUp += SignUp;
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

        private void SignUp(object sender, EventArgs e)
        {
            MessageBox.Show("SignUp");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var graphicsPath = GetRoundRectPath(this.ClientRectangle, 20))
            {
                this.Region = new Region(graphicsPath);
                using (var pen = new Pen(Color.Transparent, 1.6f))
                {
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
        }

        private GraphicsPath GetRoundRectPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
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
