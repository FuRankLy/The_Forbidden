
namespace The_Forbidden
{
    partial class frmRetry
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
            this.picMessage = new System.Windows.Forms.PictureBox();
            this.picRespawn = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRespawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picMessage
            // 
            this.picMessage.Image = global::The_Forbidden.Properties.Resources.Fail_Message;
            this.picMessage.Location = new System.Drawing.Point(122, 307);
            this.picMessage.Name = "picMessage";
            this.picMessage.Size = new System.Drawing.Size(1063, 101);
            this.picMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMessage.TabIndex = 3;
            this.picMessage.TabStop = false;
            // 
            // picRespawn
            // 
            this.picRespawn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picRespawn.Image = global::The_Forbidden.Properties.Resources.Respawn_U1;
            this.picRespawn.Location = new System.Drawing.Point(475, 479);
            this.picRespawn.Name = "picRespawn";
            this.picRespawn.Size = new System.Drawing.Size(323, 56);
            this.picRespawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRespawn.TabIndex = 1;
            this.picRespawn.TabStop = false;
            this.picRespawn.Click += new System.EventHandler(this.picRespawn_Click);
            this.picRespawn.MouseLeave += new System.EventHandler(this.picRespawn_MouseLeave);
            this.picRespawn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picRespawn_MouseMove);
            // 
            // picBackground
            // 
            this.picBackground.Image = global::The_Forbidden.Properties.Resources.Background_3_0;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1280, 720);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // frmRetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.picMessage);
            this.Controls.Add(this.picRespawn);
            this.Controls.Add(this.picBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRetry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRespawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.PictureBox picRespawn;
        private System.Windows.Forms.PictureBox picMessage;
    }
}