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
    public partial class ImageBox : UserControl
    {
        public ImageBox()
        {
            InitializeComponent();
        }

        public ImageBox(string currentTime, string senderAvatarPath, string file)
        {
            InitializeComponent();
            lbTime.Text = currentTime;
            myChatAvatar.BackgroundImage = Image.FromFile(senderAvatarPath);
            myImage.BackgroundImage = Image.FromFile(file);
        }
    }
}
