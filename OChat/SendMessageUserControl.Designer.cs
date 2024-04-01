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
            this.btnEmoji = new FontAwesome.Sharp.IconButton();
            this.btnUploadVideo = new FontAwesome.Sharp.IconButton();
            this.btnSend = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new FontAwesome.Sharp.IconButton();
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(805, 43);
            this.textBox1.TabIndex = 7;
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
            // SendMessageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnEmoji);
            this.Controls.Add(this.btnUploadVideo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUploadImage);
            this.Name = "SendMessageUserControl";
            this.Size = new System.Drawing.Size(1060, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEmoji;
        private FontAwesome.Sharp.IconButton btnUploadVideo;
        private FontAwesome.Sharp.IconButton btnSend;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnUploadImage;
    }
}
