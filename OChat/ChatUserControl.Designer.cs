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
            this.Status = new System.Windows.Forms.Label();
            this.statusImage = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(178, 64);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(81, 31);
            this.Status.TabIndex = 8;
            this.Status.Text = "Online";
            // 
            // statusImage
            // 
            this.statusImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusImage.BackgroundImage")));
            this.statusImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusImage.Location = new System.Drawing.Point(127, 60);
            this.statusImage.Name = "statusImage";
            this.statusImage.Size = new System.Drawing.Size(45, 40);
            this.statusImage.TabIndex = 7;
            this.statusImage.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(121, 20);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(181, 35);
            this.Username.TabIndex = 6;
            this.Username.Text = "Nguyễn Mạnh";
            // 
            // Avatar
            // 
            this.Avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Avatar.BackgroundImage")));
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar.Location = new System.Drawing.Point(30, 20);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(85, 80);
            this.Avatar.TabIndex = 5;
            this.Avatar.TabStop = false;
            // 
            // ChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.statusImage);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Avatar);
            this.Name = "ChatUserControl";
            this.Size = new System.Drawing.Size(340, 120);
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.PictureBox statusImage;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox Avatar;
    }
}
