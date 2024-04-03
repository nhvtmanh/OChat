using System.Drawing;

namespace OChat
{
    partial class SendMessageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMessageUserControl));
            this.btnEmoji = new FontAwesome.Sharp.IconButton();
            this.btnUploadVideo = new FontAwesome.Sharp.IconButton();
            this.btnSend = new FontAwesome.Sharp.IconButton();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new FontAwesome.Sharp.IconButton();
            this.panelEmoji = new System.Windows.Forms.Panel();
            this.pemo5 = new System.Windows.Forms.PictureBox();
            this.pemo4 = new System.Windows.Forms.PictureBox();
            this.pemo3 = new System.Windows.Forms.PictureBox();
            this.pemo2 = new System.Windows.Forms.PictureBox();
            this.pemo1 = new System.Windows.Forms.PictureBox();
            this.panelEmoji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pemo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemo1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmoji
            // 
            this.btnEmoji.FlatAppearance.BorderSize = 0;
            this.btnEmoji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmoji.IconChar = FontAwesome.Sharp.IconChar.Smile;
            this.btnEmoji.IconColor = System.Drawing.Color.Black;
            this.btnEmoji.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmoji.Location = new System.Drawing.Point(925, 16);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnEmoji.Size = new System.Drawing.Size(38, 38);
            this.btnEmoji.TabIndex = 10;
            this.btnEmoji.UseVisualStyleBackColor = true;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // btnUploadVideo
            // 
            this.btnUploadVideo.FlatAppearance.BorderSize = 0;
            this.btnUploadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadVideo.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnUploadVideo.IconColor = System.Drawing.Color.Black;
            this.btnUploadVideo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUploadVideo.Location = new System.Drawing.Point(85, 5);
            this.btnUploadVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadVideo.Name = "btnUploadVideo";
            this.btnUploadVideo.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.btnUploadVideo.Size = new System.Drawing.Size(60, 60);
            this.btnUploadVideo.TabIndex = 9;
            this.btnUploadVideo.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSend.IconColor = System.Drawing.Color.Black;
            this.btnSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSend.Location = new System.Drawing.Point(980, 5);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.btnSend.Size = new System.Drawing.Size(60, 60);
            this.btnSend.TabIndex = 8;
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbChat
            // 
            this.tbChat.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChat.Location = new System.Drawing.Point(160, 14);
            this.tbChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(805, 43);
            this.tbChat.TabIndex = 7;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnUploadImage.IconColor = System.Drawing.Color.Black;
            this.btnUploadImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUploadImage.Location = new System.Drawing.Point(20, 5);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.btnUploadImage.Size = new System.Drawing.Size(60, 60);
            this.btnUploadImage.TabIndex = 6;
            this.btnUploadImage.UseVisualStyleBackColor = true;
            // 
            // panelEmoji
            // 
            this.panelEmoji.Controls.Add(this.pemo5);
            this.panelEmoji.Controls.Add(this.pemo4);
            this.panelEmoji.Controls.Add(this.pemo3);
            this.panelEmoji.Controls.Add(this.pemo2);
            this.panelEmoji.Controls.Add(this.pemo1);
            this.panelEmoji.Location = new System.Drawing.Point(699, 16);
            this.panelEmoji.Name = "panelEmoji";
            this.panelEmoji.Size = new System.Drawing.Size(220, 38);
            this.panelEmoji.TabIndex = 11;
            // 
            // pemo5
            // 
            this.pemo5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pemo5.BackgroundImage")));
            this.pemo5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pemo5.Location = new System.Drawing.Point(179, 0);
            this.pemo5.Name = "pemo5";
            this.pemo5.Size = new System.Drawing.Size(38, 38);
            this.pemo5.TabIndex = 4;
            this.pemo5.TabStop = false;
            this.pemo5.Click += new System.EventHandler(this.pemo_Click);
            // 
            // pemo4
            // 
            this.pemo4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pemo4.BackgroundImage")));
            this.pemo4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pemo4.Location = new System.Drawing.Point(135, 0);
            this.pemo4.Name = "pemo4";
            this.pemo4.Size = new System.Drawing.Size(38, 38);
            this.pemo4.TabIndex = 3;
            this.pemo4.TabStop = false;
            this.pemo4.Click += new System.EventHandler(this.pemo_Click);
            // 
            // pemo3
            // 
            this.pemo3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pemo3.BackgroundImage")));
            this.pemo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pemo3.Location = new System.Drawing.Point(91, 0);
            this.pemo3.Name = "pemo3";
            this.pemo3.Size = new System.Drawing.Size(38, 38);
            this.pemo3.TabIndex = 2;
            this.pemo3.TabStop = false;
            this.pemo3.Click += new System.EventHandler(this.pemo_Click);
            // 
            // pemo2
            // 
            this.pemo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pemo2.BackgroundImage")));
            this.pemo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pemo2.Location = new System.Drawing.Point(47, 0);
            this.pemo2.Name = "pemo2";
            this.pemo2.Size = new System.Drawing.Size(38, 38);
            this.pemo2.TabIndex = 1;
            this.pemo2.TabStop = false;
            this.pemo2.Click += new System.EventHandler(this.pemo_Click);
            // 
            // pemo1
            // 
            this.pemo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pemo1.BackgroundImage")));
            this.pemo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pemo1.Location = new System.Drawing.Point(3, 0);
            this.pemo1.Name = "pemo1";
            this.pemo1.Size = new System.Drawing.Size(38, 38);
            this.pemo1.TabIndex = 0;
            this.pemo1.TabStop = false;
            this.pemo1.Click += new System.EventHandler(this.pemo_Click);
            // 
            // SendMessageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelEmoji);
            this.Controls.Add(this.btnEmoji);
            this.Controls.Add(this.btnUploadVideo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.btnUploadImage);
            this.Name = "SendMessageUserControl";
            this.Size = new System.Drawing.Size(1060, 74);
            this.panelEmoji.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pemo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEmoji;
        private FontAwesome.Sharp.IconButton btnUploadVideo;
        private FontAwesome.Sharp.IconButton btnSend;
        private System.Windows.Forms.TextBox tbChat;
        private FontAwesome.Sharp.IconButton btnUploadImage;
        private System.Windows.Forms.Panel panelEmoji;
        private System.Windows.Forms.PictureBox pemo1;
        private System.Windows.Forms.PictureBox pemo5;
        private System.Windows.Forms.PictureBox pemo4;
        private System.Windows.Forms.PictureBox pemo3;
        private System.Windows.Forms.PictureBox pemo2;
    }
}
