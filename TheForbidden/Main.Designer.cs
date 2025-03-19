
namespace The_Forbidden
{
    partial class frmMain
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
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picExit
            // 
            this.picExit.Image = global::The_Forbidden.Properties.Resources.ExitUnPRESSED;
            this.picExit.Location = new System.Drawing.Point(587, 516);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(113, 35);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            this.picExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseMove);
            // 
            // picHelp
            // 
            this.picHelp.Image = global::The_Forbidden.Properties.Resources.HelpUN;
            this.picHelp.Location = new System.Drawing.Point(587, 459);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(113, 35);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelp.TabIndex = 5;
            this.picHelp.TabStop = false;
            this.picHelp.Click += new System.EventHandler(this.picHelp_Click);
            this.picHelp.MouseLeave += new System.EventHandler(this.picHelp_MouseLeave);
            this.picHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picHelp_MouseMove);
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.SystemColors.Window;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPlay.Image = global::The_Forbidden.Properties.Resources.PlayU;
            this.picPlay.Location = new System.Drawing.Point(587, 402);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(113, 35);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlay.TabIndex = 2;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            this.picPlay.MouseLeave += new System.EventHandler(this.picPlay_MouseLeave);
            this.picPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPlay_MouseMove);
            // 
            // picTitle
            // 
            this.picTitle.Image = global::The_Forbidden.Properties.Resources.Title_New;
            this.picTitle.Location = new System.Drawing.Point(398, 279);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(494, 112);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 1;
            this.picTitle.TabStop = false;
            // 
            // picBackground
            // 
            this.picBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackground.Image = global::The_Forbidden.Properties.Resources.Background_3_0;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1280, 720);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 3;
            this.picBackground.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.picBackground);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Forbidden (Alpha 23.05.22)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.PictureBox picExit;
    }
}

