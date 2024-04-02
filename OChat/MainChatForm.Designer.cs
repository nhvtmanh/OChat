﻿using System.Drawing;
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
            this.friendPanel = new System.Windows.Forms.Panel();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.userPanel = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.statusImage = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnAlbum = new FontAwesome.Sharp.IconButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.albumPanel = new System.Windows.Forms.Panel();
            this.flVideoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flImagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.MainSettingPanel = new System.Windows.Forms.Panel();
            this.rbVN = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbLang = new System.Windows.Forms.Label();
            this.rbDark = new System.Windows.Forms.RadioButton();
            this.rbLight = new System.Windows.Forms.RadioButton();
            this.lbUIMode = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lbSetting = new System.Windows.Forms.Label();
            this.settingIcon = new FontAwesome.Sharp.IconPictureBox();
            this.videoItem1 = new OChat.VideoItem();
            this.videoItem2 = new OChat.VideoItem();
            this.imageItem1 = new OChat.ImageItem();
            this.imageItem2 = new OChat.ImageItem();
            this.imageItem3 = new OChat.ImageItem();
            this.imageItem4 = new OChat.ImageItem();
            this.imageItem5 = new OChat.ImageItem();
            this.imageItem6 = new OChat.ImageItem();
            this.imageItem7 = new OChat.ImageItem();
            this.imageItem8 = new OChat.ImageItem();
            this.imageItem9 = new OChat.ImageItem();
            this.chatUserControl4 = new OChat.ChatUserControl();
            this.chatUserControl9 = new OChat.ChatUserControl();
            this.chatUserControl8 = new OChat.ChatUserControl();
            this.chatUserControl7 = new OChat.ChatUserControl();
            this.chatUserControl6 = new OChat.ChatUserControl();
            this.chatUserControl5 = new OChat.ChatUserControl();
            this.chatUserControl3 = new OChat.ChatUserControl();
            this.chatUserControl2 = new OChat.ChatUserControl();
            this.chatUserControl1 = new OChat.ChatUserControl();
            this.videoBox1 = new OChat.VideoBox();
            this.chatBox3 = new OChat.ChatBox();
            this.chatBox2 = new OChat.ChatBox();
            this.chatBox1 = new OChat.ChatBox();
            this.leftPanel.SuspendLayout();
            this.friendPanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.albumPanel.SuspendLayout();
            this.flVideoPanel.SuspendLayout();
            this.flImagePanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.MainSettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.leftPanel.Controls.Add(this.friendPanel);
            this.leftPanel.Controls.Add(this.settingPanel);
            this.leftPanel.Controls.Add(this.userPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(340, 900);
            this.leftPanel.TabIndex = 0;
            // 
            // friendPanel
            // 
            this.friendPanel.AutoScroll = true;
            this.friendPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.friendPanel.Controls.Add(this.chatUserControl9);
            this.friendPanel.Controls.Add(this.chatUserControl8);
            this.friendPanel.Controls.Add(this.chatUserControl7);
            this.friendPanel.Controls.Add(this.chatUserControl6);
            this.friendPanel.Controls.Add(this.chatUserControl5);
            this.friendPanel.Controls.Add(this.chatUserControl3);
            this.friendPanel.Controls.Add(this.chatUserControl2);
            this.friendPanel.Controls.Add(this.chatUserControl1);
            this.friendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendPanel.Location = new System.Drawing.Point(0, 140);
            this.friendPanel.Name = "friendPanel";
            this.friendPanel.Size = new System.Drawing.Size(340, 660);
            this.friendPanel.TabIndex = 2;
            // 
            // settingPanel
            // 
            this.settingPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.settingPanel.Controls.Add(this.btnLogout);
            this.settingPanel.Controls.Add(this.btnSetting);
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingPanel.Location = new System.Drawing.Point(0, 800);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(340, 100);
            this.settingPanel.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 42;
            this.btnLogout.Location = new System.Drawing.Point(0, 50);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 2, 0, 6);
            this.btnLogout.Size = new System.Drawing.Size(340, 50);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSetting.IconColor = System.Drawing.Color.Black;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 42;
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(12, 2, 0, 6);
            this.btnSetting.Size = new System.Drawing.Size(340, 50);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
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
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar.Location = new System.Drawing.Point(30, 30);
            this.Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(85, 80);
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Size = new System.Drawing.Size(1060, 760);
            this.splitContainer.SplitterDistance = 685;
            this.splitContainer.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.topPanel.Controls.Add(this.btnAlbum);
            this.topPanel.Controls.Add(this.tbSearch);
            this.topPanel.Controls.Add(this.iconPictureBox1);
            this.topPanel.Controls.Add(this.chatUserControl4);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1060, 140);
            this.topPanel.TabIndex = 1;
            // 
            // btnAlbum
            // 
            this.btnAlbum.FlatAppearance.BorderSize = 0;
            this.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbum.IconChar = FontAwesome.Sharp.IconChar.PhotoFilm;
            this.btnAlbum.IconColor = System.Drawing.Color.Black;
            this.btnAlbum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlbum.Location = new System.Drawing.Point(883, 39);
            this.btnAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.btnAlbum.Size = new System.Drawing.Size(60, 60);
            this.btnAlbum.TabIndex = 10;
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(399, 48);
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
            this.iconPictureBox1.Location = new System.Drawing.Point(350, 53);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 43);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
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
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.splitContainer);
            this.MainPanel.Controls.Add(this.albumPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 140);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1060, 760);
            this.MainPanel.TabIndex = 2;
            // 
            // albumPanel
            // 
            this.albumPanel.Controls.Add(this.flVideoPanel);
            this.albumPanel.Controls.Add(this.flImagePanel);
            this.albumPanel.Controls.Add(this.label2);
            this.albumPanel.Controls.Add(this.label1);
            this.albumPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumPanel.Location = new System.Drawing.Point(0, 0);
            this.albumPanel.Name = "albumPanel";
            this.albumPanel.Size = new System.Drawing.Size(1060, 760);
            this.albumPanel.TabIndex = 0;
            this.albumPanel.Visible = false;
            // 
            // flVideoPanel
            // 
            this.flVideoPanel.AutoScroll = true;
            this.flVideoPanel.Controls.Add(this.videoItem1);
            this.flVideoPanel.Controls.Add(this.videoItem2);
            this.flVideoPanel.Location = new System.Drawing.Point(60, 297);
            this.flVideoPanel.Name = "flVideoPanel";
            this.flVideoPanel.Size = new System.Drawing.Size(930, 440);
            this.flVideoPanel.TabIndex = 3;
            // 
            // flImagePanel
            // 
            this.flImagePanel.AutoScroll = true;
            this.flImagePanel.Controls.Add(this.imageItem1);
            this.flImagePanel.Controls.Add(this.imageItem2);
            this.flImagePanel.Controls.Add(this.imageItem3);
            this.flImagePanel.Controls.Add(this.imageItem4);
            this.flImagePanel.Controls.Add(this.imageItem5);
            this.flImagePanel.Controls.Add(this.imageItem6);
            this.flImagePanel.Controls.Add(this.imageItem7);
            this.flImagePanel.Controls.Add(this.imageItem8);
            this.flImagePanel.Controls.Add(this.imageItem9);
            this.flImagePanel.Location = new System.Drawing.Point(60, 60);
            this.flImagePanel.Name = "flImagePanel";
            this.flImagePanel.Size = new System.Drawing.Size(930, 185);
            this.flImagePanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Videos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Images";
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.MainPanel);
            this.rightPanel.Controls.Add(this.topPanel);
            this.rightPanel.Controls.Add(this.MainSettingPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(340, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(1060, 900);
            this.rightPanel.TabIndex = 0;
            // 
            // MainSettingPanel
            // 
            this.MainSettingPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainSettingPanel.Controls.Add(this.rbVN);
            this.MainSettingPanel.Controls.Add(this.rbEnglish);
            this.MainSettingPanel.Controls.Add(this.rbLang);
            this.MainSettingPanel.Controls.Add(this.rbDark);
            this.MainSettingPanel.Controls.Add(this.rbLight);
            this.MainSettingPanel.Controls.Add(this.lbUIMode);
            this.MainSettingPanel.Controls.Add(this.iconButton1);
            this.MainSettingPanel.Controls.Add(this.iconButton2);
            this.MainSettingPanel.Controls.Add(this.lbSetting);
            this.MainSettingPanel.Controls.Add(this.settingIcon);
            this.MainSettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSettingPanel.Location = new System.Drawing.Point(0, 0);
            this.MainSettingPanel.Name = "MainSettingPanel";
            this.MainSettingPanel.Size = new System.Drawing.Size(1060, 900);
            this.MainSettingPanel.TabIndex = 0;
            this.MainSettingPanel.Visible = false;
            // 
            // rbVN
            // 
            this.rbVN.AutoSize = true;
            this.rbVN.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVN.Location = new System.Drawing.Point(280, 380);
            this.rbVN.Name = "rbVN";
            this.rbVN.Size = new System.Drawing.Size(196, 46);
            this.rbVN.TabIndex = 13;
            this.rbVN.Text = "Vietnamese";
            this.rbVN.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Checked = true;
            this.rbEnglish.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnglish.Location = new System.Drawing.Point(280, 328);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(343, 46);
            this.rbEnglish.TabIndex = 12;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English (United States)";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbLang
            // 
            this.rbLang.AutoSize = true;
            this.rbLang.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLang.Location = new System.Drawing.Point(70, 350);
            this.rbLang.Name = "rbLang";
            this.rbLang.Size = new System.Drawing.Size(166, 45);
            this.rbLang.TabIndex = 11;
            this.rbLang.Text = "Language";
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDark.Location = new System.Drawing.Point(280, 210);
            this.rbDark.Name = "rbDark";
            this.rbDark.Size = new System.Drawing.Size(100, 46);
            this.rbDark.TabIndex = 10;
            this.rbDark.Text = "Dark";
            this.rbDark.UseVisualStyleBackColor = true;
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Checked = true;
            this.rbLight.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLight.Location = new System.Drawing.Point(280, 158);
            this.rbLight.Name = "rbLight";
            this.rbLight.Size = new System.Drawing.Size(106, 46);
            this.rbLight.TabIndex = 9;
            this.rbLight.TabStop = true;
            this.rbLight.Text = "Light";
            this.rbLight.UseVisualStyleBackColor = true;
            // 
            // lbUIMode
            // 
            this.lbUIMode.AutoSize = true;
            this.lbUIMode.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUIMode.Location = new System.Drawing.Point(70, 180);
            this.lbUIMode.Name = "lbUIMode";
            this.lbUIMode.Size = new System.Drawing.Size(151, 45);
            this.lbUIMode.TabIndex = 8;
            this.lbUIMode.Text = "UI Mode";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(1005, 2);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(51, 50);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(949, 2);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.iconButton2.Size = new System.Drawing.Size(51, 50);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // lbSetting
            // 
            this.lbSetting.AutoSize = true;
            this.lbSetting.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetting.Location = new System.Drawing.Point(153, 35);
            this.lbSetting.Name = "lbSetting";
            this.lbSetting.Size = new System.Drawing.Size(159, 54);
            this.lbSetting.TabIndex = 3;
            this.lbSetting.Text = "Setting";
            // 
            // settingIcon
            // 
            this.settingIcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.settingIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingIcon.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.settingIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.settingIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingIcon.IconSize = 80;
            this.settingIcon.Location = new System.Drawing.Point(67, 30);
            this.settingIcon.Name = "settingIcon";
            this.settingIcon.Size = new System.Drawing.Size(80, 80);
            this.settingIcon.TabIndex = 2;
            this.settingIcon.TabStop = false;
            // 
            // videoItem1
            // 
            this.videoItem1.Location = new System.Drawing.Point(3, 3);
            this.videoItem1.Name = "videoItem1";
            this.videoItem1.Size = new System.Drawing.Size(900, 440);
            this.videoItem1.TabIndex = 0;
            // 
            // videoItem2
            // 
            this.videoItem2.Location = new System.Drawing.Point(3, 449);
            this.videoItem2.Name = "videoItem2";
            this.videoItem2.Size = new System.Drawing.Size(900, 440);
            this.videoItem2.TabIndex = 1;
            // 
            // imageItem1
            // 
            this.imageItem1.Location = new System.Drawing.Point(3, 3);
            this.imageItem1.Name = "imageItem1";
            this.imageItem1.Size = new System.Drawing.Size(176, 176);
            this.imageItem1.TabIndex = 0;
            // 
            // imageItem2
            // 
            this.imageItem2.Location = new System.Drawing.Point(185, 3);
            this.imageItem2.Name = "imageItem2";
            this.imageItem2.Size = new System.Drawing.Size(176, 176);
            this.imageItem2.TabIndex = 1;
            // 
            // imageItem3
            // 
            this.imageItem3.Location = new System.Drawing.Point(367, 3);
            this.imageItem3.Name = "imageItem3";
            this.imageItem3.Size = new System.Drawing.Size(176, 176);
            this.imageItem3.TabIndex = 2;
            // 
            // imageItem4
            // 
            this.imageItem4.Location = new System.Drawing.Point(549, 3);
            this.imageItem4.Name = "imageItem4";
            this.imageItem4.Size = new System.Drawing.Size(176, 176);
            this.imageItem4.TabIndex = 3;
            // 
            // imageItem5
            // 
            this.imageItem5.Location = new System.Drawing.Point(731, 3);
            this.imageItem5.Name = "imageItem5";
            this.imageItem5.Size = new System.Drawing.Size(176, 176);
            this.imageItem5.TabIndex = 4;
            // 
            // imageItem6
            // 
            this.imageItem6.Location = new System.Drawing.Point(3, 185);
            this.imageItem6.Name = "imageItem6";
            this.imageItem6.Size = new System.Drawing.Size(176, 176);
            this.imageItem6.TabIndex = 5;
            // 
            // imageItem7
            // 
            this.imageItem7.Location = new System.Drawing.Point(185, 185);
            this.imageItem7.Name = "imageItem7";
            this.imageItem7.Size = new System.Drawing.Size(176, 176);
            this.imageItem7.TabIndex = 6;
            // 
            // imageItem8
            // 
            this.imageItem8.Location = new System.Drawing.Point(367, 185);
            this.imageItem8.Name = "imageItem8";
            this.imageItem8.Size = new System.Drawing.Size(176, 176);
            this.imageItem8.TabIndex = 7;
            // 
            // imageItem9
            // 
            this.imageItem9.Location = new System.Drawing.Point(549, 185);
            this.imageItem9.Name = "imageItem9";
            this.imageItem9.Size = new System.Drawing.Size(176, 176);
            this.imageItem9.TabIndex = 8;
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
            // chatUserControl9
            // 
            this.chatUserControl9.BackColor = System.Drawing.Color.White;
            this.chatUserControl9.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl9.Location = new System.Drawing.Point(0, 686);
            this.chatUserControl9.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl9.Name = "chatUserControl9";
            this.chatUserControl9.Size = new System.Drawing.Size(323, 98);
            this.chatUserControl9.TabIndex = 7;
            // 
            // chatUserControl8
            // 
            this.chatUserControl8.BackColor = System.Drawing.Color.White;
            this.chatUserControl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl8.Location = new System.Drawing.Point(0, 588);
            this.chatUserControl8.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl8.Name = "chatUserControl8";
            this.chatUserControl8.Size = new System.Drawing.Size(323, 98);
            this.chatUserControl8.TabIndex = 6;
            // 
            // chatUserControl7
            // 
            this.chatUserControl7.BackColor = System.Drawing.Color.White;
            this.chatUserControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl7.Location = new System.Drawing.Point(0, 490);
            this.chatUserControl7.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl7.Name = "chatUserControl7";
            this.chatUserControl7.Size = new System.Drawing.Size(323, 98);
            this.chatUserControl7.TabIndex = 5;
            // 
            // chatUserControl6
            // 
            this.chatUserControl6.BackColor = System.Drawing.Color.White;
            this.chatUserControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl6.Location = new System.Drawing.Point(0, 392);
            this.chatUserControl6.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl6.Name = "chatUserControl6";
            this.chatUserControl6.Size = new System.Drawing.Size(323, 98);
            this.chatUserControl6.TabIndex = 4;
            // 
            // chatUserControl5
            // 
            this.chatUserControl5.BackColor = System.Drawing.Color.White;
            this.chatUserControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl5.Location = new System.Drawing.Point(0, 294);
            this.chatUserControl5.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl5.Name = "chatUserControl5";
            this.chatUserControl5.Size = new System.Drawing.Size(323, 98);
            this.chatUserControl5.TabIndex = 3;
            // 
            // chatUserControl3
            // 
            this.chatUserControl3.BackColor = System.Drawing.Color.White;
            this.chatUserControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl3.Location = new System.Drawing.Point(0, 196);
            this.chatUserControl3.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl3.Name = "chatUserControl3";
            this.chatUserControl3.Size = new System.Drawing.Size(323, 98);
            this.chatUserControl3.TabIndex = 2;
            // 
            // chatUserControl2
            // 
            this.chatUserControl2.BackColor = System.Drawing.Color.White;
            this.chatUserControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl2.Location = new System.Drawing.Point(0, 98);
            this.chatUserControl2.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl2.Name = "chatUserControl2";
            this.chatUserControl2.Size = new System.Drawing.Size(323, 98);
            this.chatUserControl2.TabIndex = 1;
            // 
            // chatUserControl1
            // 
            this.chatUserControl1.BackColor = System.Drawing.Color.White;
            this.chatUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatUserControl1.Location = new System.Drawing.Point(0, 0);
            this.chatUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.chatUserControl1.Name = "chatUserControl1";
            this.chatUserControl1.Size = new System.Drawing.Size(323, 98);
            this.chatUserControl1.TabIndex = 0;
            // 
            // videoBox1
            // 
            this.videoBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoBox1.Location = new System.Drawing.Point(0, 276);
            this.videoBox1.Name = "videoBox1";
            this.videoBox1.Size = new System.Drawing.Size(1043, 448);
            this.videoBox1.TabIndex = 3;
            // 
            // chatBox3
            // 
            this.chatBox3.AutoSize = true;
            this.chatBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBox3.Location = new System.Drawing.Point(0, 184);
            this.chatBox3.Name = "chatBox3";
            this.chatBox3.Size = new System.Drawing.Size(1043, 92);
            this.chatBox3.TabIndex = 2;
            // 
            // chatBox2
            // 
            this.chatBox2.AutoSize = true;
            this.chatBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBox2.Location = new System.Drawing.Point(0, 92);
            this.chatBox2.Name = "chatBox2";
            this.chatBox2.Size = new System.Drawing.Size(1043, 92);
            this.chatBox2.TabIndex = 1;
            // 
            // chatBox1
            // 
            this.chatBox1.AutoSize = true;
            this.chatBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBox1.Location = new System.Drawing.Point(0, 0);
            this.chatBox1.Name = "chatBox1";
            this.chatBox1.Size = new System.Drawing.Size(1043, 92);
            this.chatBox1.TabIndex = 0;
            // 
            // MainChatForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainChatForm";
            this.leftPanel.ResumeLayout(false);
            this.friendPanel.ResumeLayout(false);
            this.settingPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.albumPanel.ResumeLayout(false);
            this.albumPanel.PerformLayout();
            this.flVideoPanel.ResumeLayout(false);
            this.flImagePanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.MainSettingPanel.ResumeLayout(false);
            this.MainSettingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingIcon)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ChatUserControl chatUserControl4;
        private System.Windows.Forms.SplitContainer splitContainer;
        private TextBox tbSearch;
        private ChatBox chatBox3;
        private ChatBox chatBox2;
        private ChatBox chatBox1;
        private VideoBox videoBox1;
        private FontAwesome.Sharp.IconButton btnAlbum;
        private Panel MainPanel;
        private Panel albumPanel;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flImagePanel;
        private ImageItem imageItem1;
        private ImageItem imageItem2;
        private ImageItem imageItem3;
        private ImageItem imageItem4;
        private ImageItem imageItem5;
        private ImageItem imageItem6;
        private ImageItem imageItem7;
        private ImageItem imageItem8;
        private ImageItem imageItem9;
        private FlowLayoutPanel flVideoPanel;
        private VideoItem videoItem1;
        private VideoItem videoItem2;
        private Panel friendPanel;
        private Panel settingPanel;
        private ChatUserControl chatUserControl9;
        private ChatUserControl chatUserControl8;
        private ChatUserControl chatUserControl7;
        private ChatUserControl chatUserControl6;
        private ChatUserControl chatUserControl5;
        private ChatUserControl chatUserControl3;
        private ChatUserControl chatUserControl2;
        private ChatUserControl chatUserControl1;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnLogout;
        private Panel rightPanel;
        private Panel MainSettingPanel;
        private FontAwesome.Sharp.IconPictureBox settingIcon;
        private Label lbSetting;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private RadioButton rbLight;
        private Label lbUIMode;
        private RadioButton rbDark;
        private RadioButton rbVN;
        private RadioButton rbEnglish;
        private Label rbLang;
    }
}