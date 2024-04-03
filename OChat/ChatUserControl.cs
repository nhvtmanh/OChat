using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OChat
{
    public partial class ChatUserControl : UserControl
    {
        public int UserId { get; set; }
        public string AvatarPath { get; set; }
        public string UserName { get; set; }
        public string StatusImagePath { get; set; }
        public string Status { get; set; }

        public ChatUserControl()
        {
            InitializeComponent();
        }

        public ChatUserControl(int userId, string avatarPath, string userName, string statusImagePath, string status)
        {
            InitializeComponent();
            UserId = userId;
            AvatarPath = avatarPath;
            UserName = userName;
            StatusImagePath = statusImagePath;
            Status = status;

            Avatar.BackgroundImage = Image.FromFile(avatarPath);
            Username.Text = userName;
            statusImage.BackgroundImage = Image.FromFile(statusImagePath);
            lbStatus.Text = status;
        }

        private void ChatUserControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#f1f5f9");
        }

        private void ChatUserControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }
    }
}
