namespace OChat
{
    partial class ImageItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageItem));
            this.lbTime = new System.Windows.Forms.Label();
            this.myImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbTime.Location = new System.Drawing.Point(3, 146);
            this.lbTime.Name = "lbTime";
            this.lbTime.Padding = new System.Windows.Forms.Padding(0, 4, 0, 5);
            this.lbTime.Size = new System.Drawing.Size(168, 30);
            this.lbTime.TabIndex = 14;
            this.lbTime.Text = "30/10/2024, 11:40 AM";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myImage
            // 
            this.myImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myImage.BackgroundImage")));
            this.myImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myImage.Location = new System.Drawing.Point(23, 10);
            this.myImage.Name = "myImage";
            this.myImage.Size = new System.Drawing.Size(130, 130);
            this.myImage.TabIndex = 15;
            this.myImage.TabStop = false;
            // 
            // ImageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myImage);
            this.Controls.Add(this.lbTime);
            this.Name = "ImageItem";
            this.Size = new System.Drawing.Size(176, 176);
            ((System.ComponentModel.ISupportInitialize)(this.myImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myImage;
        private System.Windows.Forms.Label lbTime;
    }
}
