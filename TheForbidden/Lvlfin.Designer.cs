
namespace The_Forbidden
{
    partial class frmLvlfin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLvlfin));
            this.tmrMainGame = new System.Windows.Forms.Timer(this.components);
            this.tmrJump = new System.Windows.Forms.Timer(this.components);
            this.tmrWolf = new System.Windows.Forms.Timer(this.components);
            this.picLetter = new System.Windows.Forms.PictureBox();
            this.picBlock8 = new System.Windows.Forms.PictureBox();
            this.picBlock4 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMainGame
            // 
            this.tmrMainGame.Enabled = true;
            this.tmrMainGame.Interval = 1;
            this.tmrMainGame.Tick += new System.EventHandler(this.tmrMainGame_Tick);
            // 
            // tmrJump
            // 
            this.tmrJump.Enabled = true;
            this.tmrJump.Interval = 25;
            this.tmrJump.Tick += new System.EventHandler(this.tmrJump_Tick);
            // 
            // tmrWolf
            // 
            this.tmrWolf.Enabled = true;
            this.tmrWolf.Interval = 105;
            this.tmrWolf.Tick += new System.EventHandler(this.tmrWolf_Tick);
            // 
            // picLetter
            // 
            this.picLetter.Image = global::The_Forbidden.Properties.Resources.Letter;
            this.picLetter.Location = new System.Drawing.Point(606, 648);
            this.picLetter.Name = "picLetter";
            this.picLetter.Size = new System.Drawing.Size(29, 21);
            this.picLetter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLetter.TabIndex = 18;
            this.picLetter.TabStop = false;
            // 
            // picBlock8
            // 
            this.picBlock8.Image = global::The_Forbidden.Properties.Resources.New_Piskel_1_png__1_;
            this.picBlock8.Location = new System.Drawing.Point(1277, -352);
            this.picBlock8.Name = "picBlock8";
            this.picBlock8.Size = new System.Drawing.Size(10, 1079);
            this.picBlock8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlock8.TabIndex = 17;
            this.picBlock8.TabStop = false;
            this.picBlock8.Tag = "block";
            // 
            // picBlock4
            // 
            this.picBlock4.Image = global::The_Forbidden.Properties.Resources.New_Piskel_1_png__1_;
            this.picBlock4.Location = new System.Drawing.Point(-7, -344);
            this.picBlock4.Name = "picBlock4";
            this.picBlock4.Size = new System.Drawing.Size(10, 1079);
            this.picBlock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlock4.TabIndex = 12;
            this.picBlock4.TabStop = false;
            this.picBlock4.Tag = "block";
            // 
            // picPlayer
            // 
            this.picPlayer.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer.Image")));
            this.picPlayer.Location = new System.Drawing.Point(9, 648);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(31, 39);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 6;
            this.picPlayer.TabStop = false;
            this.picPlayer.Tag = "player";
            // 
            // picGround
            // 
            this.picGround.Image = ((System.Drawing.Image)(resources.GetObject("picGround.Image")));
            this.picGround.Location = new System.Drawing.Point(0, 691);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(1280, 29);
            this.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGround.TabIndex = 4;
            this.picGround.TabStop = false;
            this.picGround.Tag = "block";
            // 
            // picBack
            // 
            this.picBack.Image = global::The_Forbidden.Properties.Resources.BACKUNPRESSED;
            this.picBack.Location = new System.Drawing.Point(12, 12);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(100, 50);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 3;
            this.picBack.TabStop = false;
            this.picBack.Tag = "transparent";
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            this.picBack.MouseLeave += new System.EventHandler(this.picBack_MouseLeave);
            this.picBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBack_MouseMove);
            // 
            // frmLvlfin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Forbidden.Properties.Resources.Background_3_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.picLetter);
            this.Controls.Add(this.picBlock8);
            this.Controls.Add(this.picBlock4);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLvlfin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picLetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.Timer tmrMainGame;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBlock4;
        private System.Windows.Forms.PictureBox picBlock8;
        private System.Windows.Forms.PictureBox picLetter;
        private System.Windows.Forms.Timer tmrJump;
        private System.Windows.Forms.Timer tmrWolf;
    }
}