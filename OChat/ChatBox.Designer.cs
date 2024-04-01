using System.Drawing;

namespace OChat
{
    partial class ChatBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBox));
            this.tbChat = new System.Windows.Forms.RichTextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.myChatAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myChatAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbChat
            // 
            this.tbChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChat.Location = new System.Drawing.Point(128, 50);
            this.tbChat.Name = "tbChat";
            this.tbChat.ReadOnly = true;
            this.tbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbChat.Size = new System.Drawing.Size(880, 40);
            this.tbChat.TabIndex = 10;
            this.tbChat.Text = "hello worldhello worldhello worldhello worldhello worldhellohello worldhello worl" +
    "dhello worldhello worldhello worldhelloworldhello worldhello worldhello worldhel" +
    "lo";
            this.tbChat.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.tbChat_ContentsResized);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbTime.Location = new System.Drawing.Point(425, 10);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(168, 21);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "30/10/2024, 11:40 AM";
            // 
            // myChatAvatar
            // 
            this.myChatAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myChatAvatar.BackgroundImage")));
            this.myChatAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myChatAvatar.Location = new System.Drawing.Point(40, 50);
            this.myChatAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myChatAvatar.Name = "myChatAvatar";
            this.myChatAvatar.Size = new System.Drawing.Size(65, 60);
            this.myChatAvatar.TabIndex = 8;
            this.myChatAvatar.TabStop = false;
            // 
            // ChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.myChatAvatar);
            this.Name = "ChatBox";
            this.Size = new System.Drawing.Size(1060, 162);
            ((System.ComponentModel.ISupportInitialize)(this.myChatAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbChat;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox myChatAvatar;
    }
}
