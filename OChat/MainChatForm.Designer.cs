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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.BotLeftPanel = new System.Windows.Forms.Panel();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.StatusIcon = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.BotLeftPanel);
            this.LeftPanel.Controls.Add(this.TopLeftPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(316, 776);
            this.LeftPanel.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(316, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(809, 776);
            this.RightPanel.TabIndex = 1;
            // 
            // TopLeftPanel
            // 
            this.TopLeftPanel.Controls.Add(this.StatusIcon);
            this.TopLeftPanel.Controls.Add(this.Status);
            this.TopLeftPanel.Controls.Add(this.Username);
            this.TopLeftPanel.Controls.Add(this.Avatar);
            this.TopLeftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLeftPanel.Name = "TopLeftPanel";
            this.TopLeftPanel.Size = new System.Drawing.Size(316, 142);
            this.TopLeftPanel.TabIndex = 0;
            // 
            // BotLeftPanel
            // 
            this.BotLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotLeftPanel.Location = new System.Drawing.Point(0, 142);
            this.BotLeftPanel.Name = "BotLeftPanel";
            this.BotLeftPanel.Size = new System.Drawing.Size(316, 634);
            this.BotLeftPanel.TabIndex = 1;
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(23, 29);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(85, 73);
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(134, 29);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(44, 16);
            this.Username.TabIndex = 1;
            this.Username.Text = "label1";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(135, 81);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(44, 16);
            this.Status.TabIndex = 2;
            this.Status.Text = "label2";
            // 
            // StatusIcon
            // 
            this.StatusIcon.Location = new System.Drawing.Point(234, 72);
            this.StatusIcon.Name = "StatusIcon";
            this.StatusIcon.Size = new System.Drawing.Size(33, 25);
            this.StatusIcon.TabIndex = 3;
            this.StatusIcon.TabStop = false;
            // 
            // MainChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 776);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainChatForm";
            this.Text = "MainChatForm";
            this.LeftPanel.ResumeLayout(false);
            this.TopLeftPanel.ResumeLayout(false);
            this.TopLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel BotLeftPanel;
        private System.Windows.Forms.Panel TopLeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.PictureBox StatusIcon;
        private System.Windows.Forms.Label Status;
    }
}