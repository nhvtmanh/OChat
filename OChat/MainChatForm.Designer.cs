using System.Drawing;

namespace OChat
{
    partial class MainChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChatForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.FriendsPanel = new System.Windows.Forms.Panel();
            this.chatUserControl3 = new OChat.ChatUserControl();
            this.chatUserControl2 = new OChat.ChatUserControl();
            this.chatUserControl1 = new OChat.ChatUserControl();
            this.userPanel = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.statusImage = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.chatUserControl4 = new OChat.ChatUserControl();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.btnUploadVideo = new FontAwesome.Sharp.IconButton();
            this.btnSend = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new FontAwesome.Sharp.IconButton();
            this.chatBox1 = new OChat.ChatBox();
            this.chatBox2 = new OChat.ChatBox();
            this.chatBox3 = new OChat.ChatBox();
            this.leftPanel.SuspendLayout();
            this.FriendsPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.ChatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.leftPanel.Controls.Add(this.FriendsPanel);
            this.leftPanel.Controls.Add(this.userPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(340, 884);
            this.leftPanel.TabIndex = 0;
            // 
            // FriendsPanel
            // 
            this.FriendsPanel.AutoScroll = true;
            this.FriendsPanel.Controls.Add(this.chatUserControl3);
            this.FriendsPanel.Controls.Add(this.chatUserControl2);
            this.FriendsPanel.Controls.Add(this.chatUserControl1);
            this.FriendsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendsPanel.Location = new System.Drawing.Point(0, 140);
            this.FriendsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendsPanel.Name = "FriendsPanel";
            this.FriendsPanel.Size = new System.Drawing.Size(340, 744);
            this.FriendsPanel.TabIndex = 1;
            // 
            // chatUserControl3
            // 
            this.chatUserControl3.BackColor = System.Drawing.Color.White;
            this.chatUserControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl3.Location = new System.Drawing.Point(0, 196);
            this.chatUserControl3.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl3.Name = "chatUserControl3";
            this.chatUserControl3.Size = new System.Drawing.Size(340, 98);
            this.chatUserControl3.TabIndex = 2;
            // 
            // chatUserControl2
            // 
            this.chatUserControl2.BackColor = System.Drawing.Color.White;
            this.chatUserControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl2.Location = new System.Drawing.Point(0, 98);
            this.chatUserControl2.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl2.Name = "chatUserControl2";
            this.chatUserControl2.Size = new System.Drawing.Size(340, 98);
            this.chatUserControl2.TabIndex = 1;
            // 
            // chatUserControl1
            // 
            this.chatUserControl1.BackColor = System.Drawing.Color.White;
            this.chatUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl1.Location = new System.Drawing.Point(0, 0);
            this.chatUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl1.Name = "chatUserControl1";
            this.chatUserControl1.Size = new System.Drawing.Size(340, 98);
            this.chatUserControl1.TabIndex = 0;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.Status);
            this.userPanel.Controls.Add(this.statusImage);
            this.userPanel.Controls.Add(this.Username);
            this.userPanel.Controls.Add(this.Avatar);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(340, 140);
            this.userPanel.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(180, 74);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(68, 25);
            this.Status.TabIndex = 4;
            this.Status.Text = "Online";
            // 
            // statusImage
            // 
            this.statusImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusImage.BackgroundImage")));
            this.statusImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusImage.Location = new System.Drawing.Point(128, 70);
            this.statusImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusImage.Name = "statusImage";
            this.statusImage.Size = new System.Drawing.Size(45, 40);
            this.statusImage.TabIndex = 3;
            this.statusImage.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(122, 30);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(154, 30);
            this.Username.TabIndex = 1;
            this.Username.Text = "Nguyễn Mạnh";
            // 
            // Avatar
            // 
            this.Avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Avatar.BackgroundImage")));
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar.Location = new System.Drawing.Point(30, 30);
            this.Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(85, 80);
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.topPanel.Controls.Add(this.chatUserControl4);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(340, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1060, 140);
            this.topPanel.TabIndex = 1;
            // 
            // chatUserControl4
            // 
            this.chatUserControl4.BackColor = System.Drawing.Color.White;
            this.chatUserControl4.Location = new System.Drawing.Point(0, 21);
            this.chatUserControl4.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl4.Name = "chatUserControl4";
            this.chatUserControl4.Size = new System.Drawing.Size(340, 98);
            this.chatUserControl4.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(1005, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(51, 50);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(949, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMinimize.Size = new System.Drawing.Size(51, 50);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 48;
            this.iconPictureBox1.Location = new System.Drawing.Point(771, 48);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(69, 48);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.MainPanel.Controls.Add(this.chatBox3);
            this.MainPanel.Controls.Add(this.chatBox2);
            this.MainPanel.Controls.Add(this.chatBox1);
            this.MainPanel.Controls.Add(this.ChatPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(340, 140);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1060, 744);
            this.MainPanel.TabIndex = 2;
            // 
            // ChatPanel
            // 
            this.ChatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChatPanel.Controls.Add(this.btnUploadVideo);
            this.ChatPanel.Controls.Add(this.btnSend);
            this.ChatPanel.Controls.Add(this.textBox1);
            this.ChatPanel.Controls.Add(this.btnUploadImage);
            this.ChatPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChatPanel.Location = new System.Drawing.Point(0, 644);
            this.ChatPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(1060, 100);
            this.ChatPanel.TabIndex = 0;
            // 
            // btnUploadVideo
            // 
            this.btnUploadVideo.FlatAppearance.BorderSize = 0;
            this.btnUploadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadVideo.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnUploadVideo.IconColor = System.Drawing.Color.Black;
            this.btnUploadVideo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUploadVideo.Location = new System.Drawing.Point(85, 20);
            this.btnUploadVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadVideo.Name = "btnUploadVideo";
            this.btnUploadVideo.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.btnUploadVideo.Size = new System.Drawing.Size(60, 60);
            this.btnUploadVideo.TabIndex = 4;
            this.btnUploadVideo.UseVisualStyleBackColor = true;
            this.btnUploadVideo.Click += new System.EventHandler(this.btnUploadVideo_Click);
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSend.IconColor = System.Drawing.Color.Black;
            this.btnSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSend.Location = new System.Drawing.Point(980, 20);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.btnSend.Size = new System.Drawing.Size(60, 60);
            this.btnSend.TabIndex = 3;
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(805, 39);
            this.textBox1.TabIndex = 2;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnUploadImage.IconColor = System.Drawing.Color.Black;
            this.btnUploadImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUploadImage.Location = new System.Drawing.Point(20, 20);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.btnUploadImage.Size = new System.Drawing.Size(60, 60);
            this.btnUploadImage.TabIndex = 1;
            this.btnUploadImage.UseVisualStyleBackColor = true;
            // 
            // chatBox1
            // 
            this.chatBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBox1.Location = new System.Drawing.Point(0, 0);
            this.chatBox1.Name = "chatBox1";
            this.chatBox1.Size = new System.Drawing.Size(1060, 162);
            this.chatBox1.TabIndex = 1;
            // 
            // chatBox2
            // 
            this.chatBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBox2.Location = new System.Drawing.Point(0, 162);
            this.chatBox2.Name = "chatBox2";
            this.chatBox2.Size = new System.Drawing.Size(1060, 162);
            this.chatBox2.TabIndex = 2;
            // 
            // chatBox3
            // 
            this.chatBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBox3.Location = new System.Drawing.Point(0, 324);
            this.chatBox3.Name = "chatBox3";
            this.chatBox3.Size = new System.Drawing.Size(1060, 162);
            this.chatBox3.TabIndex = 3;
            // 
            // MainChatForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 884);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainChatForm";
            this.leftPanel.ResumeLayout(false);
            this.FriendsPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox statusImage;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Panel FriendsPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnSend;
        private FontAwesome.Sharp.IconButton btnUploadImage;
        private FontAwesome.Sharp.IconButton btnUploadVideo;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ChatUserControl chatUserControl2;
        private ChatUserControl chatUserControl1;
        private ChatUserControl chatUserControl3;
        private ChatUserControl chatUserControl4;
        private ChatBox chatBox3;
        private ChatBox chatBox2;
        private ChatBox chatBox1;
    }
}