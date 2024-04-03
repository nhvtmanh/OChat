using AxWMPLib;
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
    public partial class VideoBox : UserControl
    {
        public VideoBox()
        {
            InitializeComponent();
            myVideo.uiMode = "mini";
            myVideo.Ctlcontrols.stop();
        }

        public VideoBox(string currentTime, string senderAvatarPath, string file)
        {
            InitializeComponent();
            myVideo.uiMode = "mini";
            myVideo.Ctlcontrols.stop();

            lbTime.Text = currentTime;
            myChatAvatar.BackgroundImage = Image.FromFile(senderAvatarPath);
            myVideo.URL = file;
        }
    }
}
