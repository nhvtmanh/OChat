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
    public partial class ImageItem : UserControl
    {
        public ImageItem()
        {
            InitializeComponent();
        }

        public ImageItem(string currentTime, string imagePath)
        {
            InitializeComponent();
            lbTime.Text = currentTime;
            myImage.BackgroundImage = Image.FromFile(imagePath);
        }
    }
}
