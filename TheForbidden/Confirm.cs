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
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
           
            picNo.BackColor = Color.Transparent;
            picYes.BackColor = Color.Transparent;
            picNo.Parent = picBackground;
            picYes.Parent = picBackground;
            picConfirm.BackColor = Color.Transparent;
            picConfirm.Parent = picBackground;

        }

        

        private void picYes_MouseLeave(object sender, EventArgs e)
        {
            picYes.Image = Properties.Resources.YESUNPRESSED;
        }

        private void picYes_MouseMove(object sender, MouseEventArgs e)
        {
            picYes.Image = Properties.Resources.YESPRESSED;
        }

        private void picYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();

            frmMain.Show();
        }

        private void picNo_Click(object sender, EventArgs e)
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
            if (frmMain.level == 5)
            {
                this.Hide();
                frmLvlfin frmLvlfin = new frmLvlfin();
                frmLvlfin.Show();
            }
        }

        private void picNo_MouseMove(object sender, MouseEventArgs e)
        {
            picNo.Image = Properties.Resources.NOPRESSED;
        }

        private void picNo_MouseLeave(object sender, EventArgs e)
        {
            picNo.Image = Properties.Resources.NOUNPRESSED;
        }
    }
}
