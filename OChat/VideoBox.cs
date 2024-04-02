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
        string path = "D:\\Music\\CHẠY NGAY ĐI - SƠN TÙNG M-TP (ONIONN REMIX).mp4";
        public VideoBox()
        {
            InitializeComponent();
            myVideo.uiMode = "mini";
            myVideo.URL = path;
            myVideo.Ctlcontrols.stop();
        }
    }
}
