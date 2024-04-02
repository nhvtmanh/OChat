using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using RichTextBox = System.Windows.Forms.RichTextBox;

namespace OChat
{
    public partial class MainChatForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public MainChatForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ResizeRedraw = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            LoadMainChatForm();
        }

        private void LoadMainChatForm()
        {
            SendMessageUserControl sendMessageUserControl = new SendMessageUserControl();
            sendMessageUserControl.Dock = DockStyle.Fill;
            sendMessageUserControl.BtnEmojiClick += btnEmoji_Click;
            splitContainer.Visible = true;
            splitContainer.Panel2.Controls.Add(sendMessageUserControl);
        }

        private void btnUploadVideo_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            //testPanel.Visible = !testPanel.Visible;
            //if (testPanel.Visible)
            //{
            //    testPanel.BringToFront();
            //}
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            splitContainer.Visible = !splitContainer.Visible;
            albumPanel.Visible = !albumPanel.Visible;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            DisplayBetweenTopPanel_MainPanel_MainSettingPanel();
        }
        // Call this method when to switch between TopPanel, MainPanel and MainSettingPanel
        public void DisplayBetweenTopPanel_MainPanel_MainSettingPanel()
        {
            topPanel.Visible = !topPanel.Visible;
            MainPanel.Visible = !MainPanel.Visible;
            MainSettingPanel.Visible = !MainSettingPanel.Visible;
        }
    }
}
