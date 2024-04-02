namespace OChat
{
    partial class VideoBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoBox));
            this.lbTime = new System.Windows.Forms.Label();
            this.myChatAvatar = new System.Windows.Forms.PictureBox();
            this.myVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.myChatAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbTime.Location = new System.Drawing.Point(446, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Padding = new System.Windows.Forms.Padding(0, 4, 0, 5);
            this.lbTime.Size = new System.Drawing.Size(168, 30);
            this.lbTime.TabIndex = 15;
            this.lbTime.Text = "30/10/2024, 11:40 AM";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myChatAvatar
            // 
            this.myChatAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myChatAvatar.BackgroundImage")));
            this.myChatAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myChatAvatar.Location = new System.Drawing.Point(40, 30);
            this.myChatAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myChatAvatar.Name = "myChatAvatar";
            this.myChatAvatar.Size = new System.Drawing.Size(65, 60);
            this.myChatAvatar.TabIndex = 14;
            this.myChatAvatar.TabStop = false;
            // 
            // myVideo
            // 
            this.myVideo.Enabled = true;
            this.myVideo.Location = new System.Drawing.Point(128, 30);
            this.myVideo.Name = "myVideo";
            this.myVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("myVideo.OcxState")));
            this.myVideo.Size = new System.Drawing.Size(880, 400);
            this.myVideo.TabIndex = 16;
            // 
            // VideoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myVideo);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.myChatAvatar);
            this.Name = "VideoBox";
            this.Size = new System.Drawing.Size(1060, 448);
            ((System.ComponentModel.ISupportInitialize)(this.myChatAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox myChatAvatar;
        private AxWMPLib.AxWindowsMediaPlayer myVideo;
    }
}
