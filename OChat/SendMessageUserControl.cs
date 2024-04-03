using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public event EventHandler BtnUploadImageClick
        {
            add { btnUploadImage.Click += value; }
            remove { btnUploadImage.Click -= value; }
        }

        public void FocusTextboxChat()
        {
            tbChat.Focus();
        }

        public void ClearTextboxChat()
        {
            tbChat.Clear();
        }

        private void pemo_Click(object sender, EventArgs e)
        {
            string emoName = ((PictureBox)sender).Name;
            string emoID = emoName[4].ToString();

            //Display emoji
            string currentTime = DateTime.Now.ToString("dd/MM/yyyy, hh:mm tt");
            string senderAvatarPath = SharedVariables.userAvatarPath;
            string file = "../../Resources/emo" + emoID + ".png";

            EmojiBox emojiBox = new EmojiBox(currentTime, senderAvatarPath, file);
            emojiBox.Dock = DockStyle.Fill;
            MainChatForm.flowLayoutPanel.Controls.Add(emojiBox);
            MainChatForm.flowLayoutPanel.VerticalScroll.Value = MainChatForm.flowLayoutPanel.VerticalScroll.Maximum;

            //Save emoji to file
            int senderID = SharedVariables.userID;
            int receiverID = MainChatForm.lastClickedControl.UserId;
            string type = "emoji";

            string data = $"{senderID}|{receiverID}|{type}|{file}|{currentTime}";

            string filePath = SharedVariables.fileDataMessagePath;
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(data);
            }
        }
    }
}
