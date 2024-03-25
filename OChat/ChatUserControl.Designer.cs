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
            this.StatusIcon = new System.Windows.Forms.PictureBox();
            this.Status = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusIcon
            // 
            this.StatusIcon.Location = new System.Drawing.Point(256, 83);
            this.StatusIcon.Name = "StatusIcon";
            this.StatusIcon.Size = new System.Drawing.Size(33, 25);
            this.StatusIcon.TabIndex = 7;
            this.StatusIcon.TabStop = false;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(157, 92);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(44, 16);
            this.Status.TabIndex = 6;
            this.Status.Text = "label2";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(156, 40);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(44, 16);
            this.Username.TabIndex = 5;
            this.Username.Text = "label1";
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(45, 40);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(85, 73);
            this.Avatar.TabIndex = 4;
            this.Avatar.TabStop = false;
            // 
            // ChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusIcon);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Avatar);
            this.Name = "ChatUserControl";
            this.Size = new System.Drawing.Size(355, 155);
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StatusIcon;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox Avatar;
    }
}
