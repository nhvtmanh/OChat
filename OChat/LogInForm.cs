﻿using System;
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
    public partial class LogInForm : UserControl
    {
        public LogInForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.BackColor = ColorTranslator.FromHtml("#ffffff");
            this.btnLogIn.BackColor = ColorTranslator.FromHtml("#2563eb");
            this.btnLogIn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            this.btnLogIn.FlatStyle = FlatStyle.Flat;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnSignUp.BackColor = ColorTranslator.FromHtml("#42b72a");
            this.btnSignUp.ForeColor = ColorTranslator.FromHtml("#ffffff");
            this.btnSignUp.FlatStyle = FlatStyle.Flat;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
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
    }
}
