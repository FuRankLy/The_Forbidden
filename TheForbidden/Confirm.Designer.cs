
namespace The_Forbidden
{
    partial class frmConfirm
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
            this.picConfirm = new System.Windows.Forms.PictureBox();
            this.picNo = new System.Windows.Forms.PictureBox();
            this.picYes = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picConfirm
            // 
            this.picConfirm.Image = global::The_Forbidden.Properties.Resources.AreYouSure;
            this.picConfirm.Location = new System.Drawing.Point(47, 345);
            this.picConfirm.Name = "picConfirm";
            this.picConfirm.Size = new System.Drawing.Size(1187, 73);
            this.picConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConfirm.TabIndex = 3;
            this.picConfirm.TabStop = false;
            // 
            // picNo
            // 
            this.picNo.Image = global::The_Forbidden.Properties.Resources.NOUNPRESSED;
            this.picNo.Location = new System.Drawing.Point(672, 529);
            this.picNo.Name = "picNo";
            this.picNo.Size = new System.Drawing.Size(100, 50);
            this.picNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNo.TabIndex = 2;
            this.picNo.TabStop = false;
            this.picNo.Click += new System.EventHandler(this.picNo_Click);
            this.picNo.MouseLeave += new System.EventHandler(this.picNo_MouseLeave);
            this.picNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picNo_MouseMove);
            // 
            // picYes
            // 
            this.picYes.Image = global::The_Forbidden.Properties.Resources.YESUNPRESSED;
            this.picYes.Location = new System.Drawing.Point(441, 529);
            this.picYes.Name = "picYes";
            this.picYes.Size = new System.Drawing.Size(100, 50);
            this.picYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYes.TabIndex = 1;
            this.picYes.TabStop = false;
            this.picYes.Click += new System.EventHandler(this.picYes_Click);
            this.picYes.MouseLeave += new System.EventHandler(this.picYes_MouseLeave);
            this.picYes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picYes_MouseMove);
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
            // frmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.picConfirm);
            this.Controls.Add(this.picNo);
            this.Controls.Add(this.picYes);
            this.Controls.Add(this.picBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.PictureBox picYes;
        private System.Windows.Forms.PictureBox picNo;
        private System.Windows.Forms.PictureBox picConfirm;
    }
}