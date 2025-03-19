using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Forbidden
{
    public partial class frmRetry : Form
    {
        public frmRetry()
        {
            InitializeComponent();   
            picRespawn.Parent = picBackground; 
            picRespawn.BackColor = Color.Transparent;
            picMessage.Parent = picBackground;
            picMessage.BackColor = Color.Transparent;
        }

        private void picRespawn_Click(object sender, EventArgs e)
        {
            if (frmMain.level == 0)
            {
                this.Hide();
                frmLvlone frmLvlone = new frmLvlone();
                frmLvlone.Show();
            }
            if (frmMain.level == 1)
            {
                this.Hide();
                frmLvltwo frmLvltwo = new frmLvltwo();
                frmLvltwo.Show();
            }
            if (frmMain.level == 2)
            {
                this.Hide();
                frmLvlthree frmLvlthree = new frmLvlthree();
                frmLvlthree.Show();
            }
            if (frmMain.level == 3)
            {
                this.Hide();
                frmLvlfour frmLvlfour = new frmLvlfour();
                frmLvlfour.Show();
            }
            if (frmMain.level == 4)
            {
                this.Hide();
                frmLvlfive frmLvlfive = new frmLvlfive();
                frmLvlfive.Show();
            }

        }

        private void picRespawn_MouseMove(object sender, MouseEventArgs e)
        {
            picRespawn.Image = Properties.Resources.Respawn_Pressed;
        }

        private void picRespawn_MouseLeave(object sender, EventArgs e)
        {
            picRespawn.Image = Properties.Resources.Respawn_U;
        }
    }
}
