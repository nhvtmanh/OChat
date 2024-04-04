using OChat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Color = System.Drawing.Color;
using Control = System.Windows.Forms.Control;
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
            LoadSettingOptioin();
        }

        private void LoadSettingOptioin()
        {
            if (Properties.Settings.Default.isLight)
            {
                   rbLight.Checked = true;
            }
            else
            {
                rbDark.Checked = true;
            }

            if (Properties.Settings.Default.isEN)
            {
                rbEnglish.Checked = true;
            }
            else
            {
                rbVN.Checked = true;
            }
        }

        private void LoadMainChatForm()
        {
            Avatar.BackgroundImage = Image.FromFile(SharedVariables.userAvatarPath);
            Username.Text = SharedVariables.userName;
            statusImage.BackgroundImage = Image.FromFile(SharedVariables.onlineImagePath);
            Status.Text = "Online";

            LoadUserFriends();

            sendMessageUserControl = new SendMessageUserControl();
            sendMessageUserControl.Dock = DockStyle.Fill;

            sendMessageUserControl.BtnSendClick += btnSend_Click;
            sendMessageUserControl.BtnUploadImageClick += btnUploadImage_Click;
            sendMessageUserControl.BtnUploadVideoClick += btnUploadVideo_Click;

            splitContainer.Visible = true;
            splitContainer.Panel2.Controls.Add(sendMessageUserControl);

            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.WrapContents = false;
            splitContainer.Panel1.Controls.Add(flowLayoutPanel);
        }

        private void btnUploadVideo_Click(object sender, EventArgs e)
        {
            int senderID = SharedVariables.userID;
            string senderAvatarPath = SharedVariables.userAvatarPath;
            int receiverID = lastClickedControl.UserId;
            string type = "video";
            string filePath = SharedVariables.fileDataMessagePath;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP4 Files|*.mp4";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    //Display all selected videos
                    string currentTime = DateTime.Now.ToString("dd/MM/yyyy, hh:mm tt");
                    VideoBox videoBox = new VideoBox(currentTime, senderAvatarPath, file);
                    videoBox.Dock = DockStyle.Fill;
                    flowLayoutPanel.Controls.Add(videoBox);
                    flowLayoutPanel.VerticalScroll.Value = flowLayoutPanel.VerticalScroll.Maximum;

                    //Save the selected images to file
                    string data = $"{senderID}|{receiverID}|{type}|{file}|{currentTime}";

                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine(data);
                    }
                }
            }
        }

        private void TestDisplayAlbumPanel()
        {
            lbSetting.Visible = false;
            btnMinimize_rightPanel.Visible = false;
            btnCLose_rightPanel.Visible = false;
            topPanel.Visible = false;
            MainPanel.Visible = true;
            albumPanel.Visible = true;
            //MessageBox.Show(topPanel.Size.ToString());
            //MessageBox.Show(MainPanel.Size.ToString());
            //MessageBox.Show(albumPanel.Size.ToString());
        }

        public static ChatUserControl lastClickedControl = null;

        private void LoadUserFriends()
        {
            string filePath = SharedVariables.fileDataUserPath;
            string[] lines = File.ReadAllLines(filePath);

            int i = 0;

            foreach (string line in lines)
            {
                i++;
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
                    btnSetting.BackColor = Color.Transparent;

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

                    lbSetting.Visible = false;
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

                //if (i == lines.Length - 1)
                //{
                //    chatUserControl.RaiseMouseClick(new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                //}
            }
        }

        private void LoadChatHistory(int receiverID)
        {
            int senderID = SharedVariables.userID;
            string filePath = SharedVariables.fileDataMessagePath;
            string senderAvatarPath = SharedVariables.userAvatarPath;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');

                if (senderID == int.Parse(data[0]) && receiverID == int.Parse(data[1]))
                {
                    if (data[2] == "text")
                    {
                        string currentTime = data[4];
                        string message = data[3];

                        ChatBox chat = new ChatBox(currentTime, senderAvatarPath, message);
                        chat.Dock = DockStyle.Fill;
                        flowLayoutPanel.Controls.Add(chat);
                    }
                    else if (data[2] == "image")
                    {
                        string currentTime = data[4];
                        string imagePath = data[3];

                        ImageBox imageBox = new ImageBox(currentTime, senderAvatarPath, imagePath);
                        imageBox.Dock = DockStyle.Fill;
                        flowLayoutPanel.Controls.Add(imageBox);
                    }
                    else if (data[2] == "emoji")
                    {
                        string currentTime = data[4];
                        string emojiPath = data[3];

                        EmojiBox emojiBox = new EmojiBox(currentTime, senderAvatarPath, emojiPath);
                        emojiBox.Dock = DockStyle.Fill;
                        flowLayoutPanel.Controls.Add(emojiBox);
                    }
                    else
                    {
                        string currentTime = data[4];
                        string videoPath = data[3];

                        VideoBox videoBox = new VideoBox(currentTime, senderAvatarPath, videoPath);
                        videoBox.Dock = DockStyle.Fill;
                        flowLayoutPanel.Controls.Add(videoBox);
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            int senderID = SharedVariables.userID;
            string senderAvatarPath = SharedVariables.userAvatarPath;
            int receiverID = lastClickedControl.UserId;
            string type = "image";
            string filePath = SharedVariables.fileDataMessagePath;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    //Display all selected images
                    string currentTime = DateTime.Now.ToString("dd/MM/yyyy, hh:mm tt");
                    ImageBox imageBox = new ImageBox(currentTime, senderAvatarPath, file);
                    imageBox.Dock = DockStyle.Fill;
                    flowLayoutPanel.Controls.Add(imageBox);
                    flowLayoutPanel.VerticalScroll.Value = flowLayoutPanel.VerticalScroll.Maximum;

                    //Save the selected images to file
                    string data = $"{senderID}|{receiverID}|{type}|{file}|{currentTime}";

                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine(data);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //private void btnEmoji_Click(object sender, EventArgs e)
        //{
            
        //}

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

            if (albumPanel.Visible)
            {
                flImagePanel.Controls.Clear();
                flVideoPanel.Controls.Clear();

                int senderID = SharedVariables.userID;
                int receiverID = lastClickedControl.UserId;

                string filePath = SharedVariables.fileDataMessagePath;

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    if (senderID == int.Parse(data[0]) && receiverID == int.Parse(data[1]))
                    {
                        if (data[2] == "image")
                        {
                            string currentTime = data[4];
                            string imagePath = data[3];

                            ImageItem imageItem = new ImageItem(currentTime, imagePath);
                            flImagePanel.Controls.Add(imageItem);
                        }
                        if (data[2] == "video")
                        {
                            string currentTime = data[4];
                            string videoPath = data[3];

                            VideoItem videoItem = new VideoItem(currentTime, videoPath);
                            flVideoPanel.Controls.Add(videoItem);
                        }
                    }
                }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            // At click effect
            btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));

            DisplayBetweenTopPanel_MainPanel_MainSettingPanel();

            //Reset color of all ChatUserControl
            foreach (var control in friendPanel.Controls)
            {
                if (control is ChatUserControl)
                {
                    ChatUserControl userControl = (ChatUserControl)control;
                    userControl.BackColor = Color.Transparent;
                }
            }
        }

        // Call this method when to switch between TopPanel, MainPanel and MainSettingPanel
        public void DisplayBetweenTopPanel_MainPanel_MainSettingPanel()
        {
            if (topPanel.Visible)
            {
                topPanel.Visible = !topPanel.Visible;
                MainPanel.Visible = !MainPanel.Visible;
                MainSettingPanel.Visible = !MainSettingPanel.Visible;
                lbSetting.Visible = true;
            }
            if (topPanel.Visible == false && MainSettingPanel.Visible == false)
            {
                MainSettingPanel.Visible = !MainSettingPanel.Visible;
                lbSetting.Visible = true;
            }
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

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = tbSearch.Text;
                Color highlightColor = ColorTranslator.FromHtml("#8DD1F1");
                bool textFound = false;

                foreach (Control control in flowLayoutPanel.Controls)
                {
                    if (control is ChatBox chatBox)
                    {
                        foreach (Control innerControl in chatBox.Controls)
                        {
                            if (innerControl is RichTextBox richTextBox)
                            {
                                // Reset formatting
                                richTextBox.SelectAll();
                                richTextBox.SelectionBackColor = richTextBox.BackColor;

                                // Find and highlight text
                                int startIndex = 0;
                                while (startIndex < richTextBox.TextLength)
                                {
                                    int index = richTextBox.Find(searchText, startIndex, RichTextBoxFinds.None);
                                    if (index != -1)
                                    {
                                        textFound = true;
                                        richTextBox.SelectionStart = index;
                                        richTextBox.SelectionLength = searchText.Length;
                                        richTextBox.SelectionBackColor = highlightColor;
                                        startIndex = index + searchText.Length;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                if (!textFound)
                {
                    MessageBox.Show("Text not found!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void SearchAndColorText(RichTextBox richTextBox, string searchText, Color color)
        {
            int startIndex = 0;
            while ((startIndex = richTextBox.Find(searchText, startIndex, RichTextBoxFinds.None)) >= 0)
            {
                richTextBox.SelectionStart = startIndex;
                richTextBox.SelectionLength = searchText.Length;
                richTextBox.SelectionColor = color;

                startIndex += searchText.Length;
            }
        }

        private void rbVN_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVN.Checked)
            {
                // Switch language to Vietnamese
                Properties.Settings.Default.isEN = false;
                Properties.Settings.Default.Save();

                UpdateUIBaseOnLanguage();
            }
        }

        private void UpdateUIBaseOnLanguage()
        {
            if (Properties.Settings.Default.isEN)
            {
                btnSetting.Text = "Setting";
                btnLogout.Text = "Logout";
                lbSetting.Text = "Setting";
                lbUIMode.Text = "UI Mode";
                rbLight.Text = "Light";
                rbDark.Text = "Dark";
                lbLang.Text = "Language";
                rbEnglish.Text = "English (United States)";
                rbVN.Text = "Vietnamese";
                label1.Text = "Images";
                label2.Text = "Videos";

                //fix UI when change English language
                if (btnLogout.Padding.Left == 23)
                {
                    btnLogout.Padding = new Padding(12, 2, 0, 6);
                }
            }
            else
            {
                btnSetting.Text = "Cài đặt";
                btnLogout.Text = "Đăng xuất";
                lbSetting.Text = "Cài đặt";
                lbUIMode.Text = "Giao diện";
                rbLight.Text = "Sáng";
                rbDark.Text = "Tối";
                lbLang.Text = "Ngôn ngữ";
                rbEnglish.Text = "Tiếng Anh - Mỹ";
                rbVN.Text = "Tiếng Việt";
                label1.Text = "Ảnh";
                label2.Text = "Video";

                //fix UI when change Vietnamese language
                btnLogout.Padding = new Padding(23, 2, 0, 6);
            }
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnglish.Checked)
            {
                // Switch language to English
                Properties.Settings.Default.isEN = true;
                Properties.Settings.Default.Save();

                UpdateUIBaseOnLanguage();
            }
        }
    }
}
