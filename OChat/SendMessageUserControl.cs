﻿using System;
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
    public partial class SendMessageUserControl : UserControl
    {
        public SendMessageUserControl()
        {
            InitializeComponent();
            //testPanel.Visible = false;
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            //testPanel.Visible = !testPanel.Visible;
        }

        public event EventHandler BtnEmojiClick
        {
            add { btnEmoji.Click += value; }
            remove { btnEmoji.Click -= value; }
        }
    }
}