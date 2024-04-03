using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Image = System.Drawing.Image;
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

        public static SendMessageUserControl sendMessageUserControl;
        public static FlowLayoutPanel flowLayoutPanel;

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
            Avatar.BackgroundImage = Image.FromFile(SharedVariables.userAvatarPath);
            Username.Text = SharedVariables.userName;
            statusImage.BackgroundImage = Image.FromFile(SharedVariables.onlineImagePath);
            Status.Text = "Online";
            lbHello.Text = "Hello, " + SharedVariables.userName;

            LoadUserFriends();

            sendMessageUserControl = new SendMessageUserControl();
            sendMessageUserControl.Dock = DockStyle.Fill;
            sendMessageUserControl.BtnEmojiClick += btnEmoji_Click;
            sendMessageUserControl.BtnSendClick += btnSend_Click;
            splitContainer.Visible = true;
            splitContainer.Panel2.Controls.Add(sendMessageUserControl);

            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.WrapContents = false;
            splitContainer.Panel1.Controls.Add(flowLayoutPanel);
        }

        private void TestDisplayAlbumPanel()
        {
            lbHello.Visible = false;
            btnMinimize_rightPanel.Visible = false;
            btnCLose_rightPanel.Visible = false;
            topPanel.Visible = false;
            MainPanel.Visible = true;
            albumPanel.Visible = true;
            //MessageBox.Show(topPanel.Size.ToString());
            //MessageBox.Show(MainPanel.Size.ToString());
            //MessageBox.Show(albumPanel.Size.ToString());
        }

        ChatUserControl lastClickedControl = null;

        private void LoadUserFriends()
        {
            string filePath = SharedVariables.fileDataUserPath;
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                int userId = int.Parse(data[0]);

                // Skip the current user
                if (userId == SharedVariables.userID)
                {
                    continue;
                }

                string avatarPath = data[5];
                string userName = data[1];
                string statusImagePath = SharedVariables.onlineImagePath;
                string status = "Online";
                if (userId % 2 == 0)
                {
                    statusImagePath = SharedVariables.offlineImagePath;
                    status = "Offline";
                }

                ChatUserControl chatUserControl = new ChatUserControl(userId, avatarPath, userName, statusImagePath, status);
                chatUserControl.Dock = DockStyle.Top;

                // Add hover effect for ChatUserControl
                chatUserControl.MouseEnter += (s, e) =>
                {
                    ChatUserControl userControl = (ChatUserControl)s;
                    if (userControl != lastClickedControl)
                    {
                        chatUserControl.BackColor = ColorTranslator.FromHtml("#f1f5f9");
                    }
                };

                chatUserControl.MouseLeave += (s, e) =>
                {
                    ChatUserControl userControl = (ChatUserControl)s;

                    // Only change the BackColor if the UserControl is not the last clicked one
                    if (userControl != lastClickedControl)
                    {
                        userControl.BackColor = Color.Transparent;
                    }
                };

                // Process click event for ChatUserControl
                chatUserControl.MouseClick += (s, e) =>
                {
                    // Reset the BackColor of all UserControls
                    foreach (var control in friendPanel.Controls)
                    {
                        if (control is ChatUserControl)
                        {
                            ChatUserControl userControl = (ChatUserControl)control;
                            userControl.BackColor = Color.Transparent; 
                        }
                    }

                    // Change the BackColor of the clicked UserControl
                    ChatUserControl clickedControl = (ChatUserControl)s;
                    clickedControl.BackColor = ColorTranslator.FromHtml("#e2e8f0");

                    // Store the clicked UserControl
                    lastClickedControl = clickedControl;

                    // Display the clicked UserControl in the top panel
                    // position of UserControl in the friendPanel is 0, 21

                    RemoveUserInTopPanel();
                    ChatUserControl newChatUserControl = new ChatUserControl(clickedControl.UserId, clickedControl.AvatarPath, clickedControl.UserName, clickedControl.StatusImagePath, clickedControl.Status);
                    newChatUserControl.Location = new Point(0, 21);
                    topPanel.Controls.Add(newChatUserControl);

                    lbHello.Visible = false;
                    btnMinimize_rightPanel.Visible = false;
                    btnCLose_rightPanel.Visible = false;

                    topPanel.Visible = true;
                    MainPanel.Visible = true;
                    MainPanel.BringToFront();

                    //Load the chat history
                    flowLayoutPanel.Controls.Clear();
                    int receiverID = clickedControl.UserId;
                    LoadChatHistory(receiverID);
                    flowLayoutPanel.VerticalScroll.Value = flowLayoutPanel.VerticalScroll.Maximum;

                    //this.Shown += new EventHandler(MyForm_Shown);
                };

                friendPanel.Controls.Add(chatUserControl);
            }
        }

        private void LoadChatHistory(int receiverID)
        {
            int senderID = SharedVariables.userID;
            string filePath = SharedVariables.fileDataMessagePath;
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');

                if (senderID == int.Parse(data[0]) && receiverID == int.Parse(data[1]))
                {
                    if (data[2] == "text")
                    {
                        string currentTime = data[4];
                        string senderAvatarPath = SharedVariables.userAvatarPath;
                        string message = data[3];

                        ChatBox chat = new ChatBox(currentTime, senderAvatarPath, message);
                        chat.Dock = DockStyle.Fill;
                        flowLayoutPanel.Controls.Add(chat);
                    }
                }
            }
        }

        //private void MyForm_Shown(object sender, EventArgs e)
        //{
        //    sendMessageUserControl.FocusTextboxChat();
        //}

        private void RemoveUserInTopPanel()
        {
            foreach (var control in topPanel.Controls)
            {
                if (control is ChatUserControl)
                {
                    topPanel.Controls.Remove((ChatUserControl)control);
                    return;
                }
            }
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            int senderID = SharedVariables.userID;
            int receiverID = lastClickedControl.UserId;
            string message = sendMessageUserControl.TextMessage;

            if (message == "")
            {
                return;
            }

            string type = "text";
            string currentTime = DateTime.Now.ToString("dd/MM/yyyy, hh:mm tt");

            //Display the message
            string senderAvatarPath = SharedVariables.userAvatarPath;
            ChatBox chat = new ChatBox(currentTime, senderAvatarPath, message);
            chat.Dock = DockStyle.Fill;
            flowLayoutPanel.Controls.Add(chat);

            //Clear the message box
            sendMessageUserControl.ClearTextboxChat();
            sendMessageUserControl.FocusTextboxChat();

            flowLayoutPanel.VerticalScroll.Value = flowLayoutPanel.VerticalScroll.Maximum;

            //Save the message to file
            string filePath = SharedVariables.fileDataMessagePath;
            string data = $"{senderID}|{receiverID}|{type}|{message}|{currentTime}";

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(data);
            }
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainStartForm mainStartForm = new MainStartForm();
            mainStartForm.ShowDialog();
            this.Close();
        }

        private void btnMinimize_rightPanel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCLose_rightPanel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimize_SettingPanel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_SettingPanel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
