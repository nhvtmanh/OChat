using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace OChat
{
    public partial class SendMessageUserControl : UserControl
    {
        public string TextMessage
        {
            get { return tbChat.Text; }
        }

        public SendMessageUserControl()
        {
            InitializeComponent();
            panelEmoji.Visible = false;
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            panelEmoji.Visible = !panelEmoji.Visible;
        }

        public event EventHandler BtnEmojiClick
        {
            add { btnEmoji.Click += value; }
            remove { btnEmoji.Click -= value; }
        }

        public event EventHandler BtnSendClick
        {
            add { btnSend.Click += value; }
            remove { btnSend.Click -= value; }
        }

        public void FocusTextboxChat()
        {
            tbChat.Focus();
        }

        public void ClearTextboxChat()
        {
            tbChat.Clear();
        }
    }
}
