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
    public partial class EmojiBox : UserControl
    {
        public EmojiBox()
        {
            InitializeComponent();
        }

        public EmojiBox(string currentTime, string senderAvatarPath, string filePath)
        {
            InitializeComponent();
            lbTime.Text = currentTime;
            myChatAvatar.BackgroundImage = Image.FromFile(senderAvatarPath);
            myEmoji.BackgroundImage = Image.FromFile(filePath);
        }
    }
}
