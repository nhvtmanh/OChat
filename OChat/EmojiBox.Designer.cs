namespace OChat
{
    partial class EmojiBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmojiBox));
            this.myEmoji = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.myChatAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myEmoji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myChatAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // myEmoji
            // 
            this.myEmoji.BackColor = System.Drawing.Color.Transparent;
            this.myEmoji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myEmoji.BackgroundImage")));
            this.myEmoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myEmoji.Location = new System.Drawing.Point(128, 30);
            this.myEmoji.Name = "myEmoji";
            this.myEmoji.Size = new System.Drawing.Size(60, 60);
            this.myEmoji.TabIndex = 16;
            this.myEmoji.TabStop = false;
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
            // EmojiBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myEmoji);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.myChatAvatar);
            this.Name = "EmojiBox";
            this.Size = new System.Drawing.Size(1060, 100);
            ((System.ComponentModel.ISupportInitialize)(this.myEmoji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myChatAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myEmoji;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox myChatAvatar;
    }
}
