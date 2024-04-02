using System.Drawing;
using System.Windows.Forms;

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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.chatUserControl4 = new OChat.ChatUserControl();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
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
            this.leftPanel.Size = new System.Drawing.Size(340, 900);
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
            this.FriendsPanel.Size = new System.Drawing.Size(340, 760);
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
            this.topPanel.Controls.Add(this.tbSearch);
            this.topPanel.Controls.Add(this.iconPictureBox1);
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
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(506, 48);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(420, 43);
            this.tbSearch.TabIndex = 9;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 43;
            this.iconPictureBox1.Location = new System.Drawing.Point(457, 53);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 43);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
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
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(340, 140);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.chatBox3);
            this.splitContainer.Panel1.Controls.Add(this.chatBox2);
            this.splitContainer.Panel1.Controls.Add(this.chatBox1);
            this.splitContainer.Size = new System.Drawing.Size(1060, 760);
            this.splitContainer.SplitterDistance = 686;
            this.splitContainer.TabIndex = 7;
            // 
            // chatBox1
            // 
            this.chatBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBox1.Location = new System.Drawing.Point(0, 0);
            this.chatBox1.Name = "chatBox1";
            this.chatBox1.Size = new System.Drawing.Size(1060, 94);
            this.chatBox1.TabIndex = 0;
            // 
            // chatBox2
            // 
            this.chatBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBox2.Location = new System.Drawing.Point(0, 94);
            this.chatBox2.Name = "chatBox2";
            this.chatBox2.Size = new System.Drawing.Size(1060, 94);
            this.chatBox2.TabIndex = 1;
            // 
            // chatBox3
            // 
            this.chatBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBox3.Location = new System.Drawing.Point(0, 188);
            this.chatBox3.Name = "chatBox3";
            this.chatBox3.Size = new System.Drawing.Size(1060, 94);
            this.chatBox3.TabIndex = 2;
            // 
            // MainChatForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ChatUserControl chatUserControl4;
        private ChatUserControl chatUserControl3;
        private ChatUserControl chatUserControl2;
        private ChatUserControl chatUserControl1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private TextBox tbSearch;
        private ChatBox chatBox3;
        private ChatBox chatBox2;
        private ChatBox chatBox1;
    }
}