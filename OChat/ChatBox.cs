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
    public partial class ChatBox : UserControl
    {
        public ChatBox()
        {
            InitializeComponent();
            ResizeRichTextBoxWidth(tbChat);
        }

        private void tbChat_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }

        private void ResizeRichTextBoxWidth(RichTextBox richTextBox)
        {
            // Create a Graphics object for the RichTextBox
            using (Graphics g = richTextBox.CreateGraphics())
            {
                // Measure the size of the text
                SizeF textSize = g.MeasureString(richTextBox.Text, richTextBox.Font);

                // Resize the RichTextBox to fit the text
                richTextBox.Width = (int)Math.Ceiling(textSize.Width);
            }
        }
    }
}
