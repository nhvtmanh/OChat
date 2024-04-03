namespace OChat
{
    partial class ChatUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatUserControl));
            this.lbStatus = new System.Windows.Forms.Label();
            this.statusImage = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(180, 53);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(68, 25);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Online";
            // 
            // statusImage
            // 
            this.statusImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusImage.BackgroundImage")));
            this.statusImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusImage.Location = new System.Drawing.Point(128, 49);
            this.statusImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusImage.Name = "statusImage";
            this.statusImage.Size = new System.Drawing.Size(45, 40);
            this.statusImage.TabIndex = 7;
            this.statusImage.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(122, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(154, 30);
            this.Username.TabIndex = 6;
            this.Username.Text = "Nguyễn Mạnh";
            // 
            // Avatar
            // 
            this.Avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Avatar.BackgroundImage")));
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar.Location = new System.Drawing.Point(30, 9);
            this.Avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(85, 80);
            this.Avatar.TabIndex = 5;
            this.Avatar.TabStop = false;
            // 
            // ChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.statusImage);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Avatar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChatUserControl";
            this.Size = new System.Drawing.Size(340, 98);
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.PictureBox statusImage;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox Avatar;
    }
}
