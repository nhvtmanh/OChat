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
    public partial class VideoItem : UserControl
    {
        public VideoItem()
        {
            InitializeComponent();
        }

        public VideoItem(string currentTime, string videoPath)
        {
            InitializeComponent();
            lbTime.Text = currentTime;
            myVideo.URL = videoPath;
        }
    }
}
