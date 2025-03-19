
namespace The_Forbidden
{
    partial class frmLoad
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
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.picQuote = new System.Windows.Forms.PictureBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQuote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrLoading
            // 
            this.tmrLoading.Enabled = true;
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // picQuote
            // 
            this.picQuote.Image = global::The_Forbidden.Properties.Resources.Quote6;
            this.picQuote.Location = new System.Drawing.Point(12, 467);
            this.picQuote.Name = "picQuote";
            this.picQuote.Size = new System.Drawing.Size(1256, 116);
            this.picQuote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuote.TabIndex = 3;
            this.picQuote.TabStop = false;
            // 
            // picLoading
            // 
            this.picLoading.Image = global::The_Forbidden.Properties.Resources.LOADING;
            this.picLoading.Location = new System.Drawing.Point(369, 142);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(556, 319);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoading.TabIndex = 2;
            this.picLoading.TabStop = false;
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
            this.picBackground.Click += new System.EventHandler(this.picBackground_Click);
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.picQuote);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.picBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.frmLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private System.Windows.Forms.PictureBox picQuote;
    }
}