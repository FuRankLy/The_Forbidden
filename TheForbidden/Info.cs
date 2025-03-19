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

    public partial class frmInfo : Form
    {
        int level;
        
        public frmInfo()
        {
            InitializeComponent();
        }
        
        private void frmInfo_Load(object sender, EventArgs e)
        {

            level = frmMain.level;
            picBackPressed.Hide();
            picBackUnpressed.BackColor = Color.Transparent;
            picBackPressed.BackColor = Color.Transparent;
            picBackUnpressed.Parent = picHelpBackground;
            picBackPressed.Parent = picHelpBackground;
            picContinue.BackColor = Color.Transparent;
            picContinue.Parent = picHelpBackground;
            
            if (level == 0)
            {
                picPrologue1.Show();
                picPrologue2.Show();
                picPrologue3.Show();

            }
            else if (level == 1)
            {
               
            }
            else if (level == 2)
            {
             
            }
            else if (level == 3)
            {
              
            }
            else if (level == 4)
            {
                
            }
            else if (level == 5)
            {
               
            }
            else if (level == 6)
            {
               
            }

        }
        
        private void picBackPressed_Click(object sender, EventArgs e)
        {
            if (level == 0 )
            {
                this.Hide();
                frmMain frmMain = new frmMain();

                frmMain.Show();
                frmMain.level--;
            }
            if (level == 1)
            {
                this.Hide();
                frmLvlone frmLvlone = new frmLvlone();

                frmLvlone.Show();
                frmMain.level--;
            }
            if (level == 2)
            {
                this.Hide();
                frmLvltwo frmLvltwo = new frmLvltwo();

                frmLvltwo.Show();
                frmMain.level--;
            }
            if (level == 3)
            {
                this.Hide();
                frmLvlthree frmLvlthree = new frmLvlthree();

                frmLvlthree.Show();
                frmMain.level--;
            }
            if (level == 4)
            {
                this.Hide();
                frmLvlfour frmLvlfour = new frmLvlfour();

                frmLvlfour.Show();
                frmMain.level--;
            }
            if (level == 5)
            {
                this.Hide();
                frmLvlfive frmLvlfive = new frmLvlfive();

                frmLvlfive.Show();
                frmMain.level--;
            }
            if (level == 6)
            {
                this.Hide();
                frmLvlfin frmLvlfin = new frmLvlfin();

                frmLvlfin.Show();
                frmMain.level--;
            }


        }

        private void picBackPressed_MouseLeave(object sender, EventArgs e)
        {
            picBackPressed.Hide();
            picBackUnpressed.Show();
        }

        private void picBackUnpressed_MouseMove(object sender, MouseEventArgs e)
        {
            picBackUnpressed.Hide();
            picBackPressed.Show();
        }

        
        private void picContinue_Click(object sender, EventArgs e)
        {
            if (level == 0)
            {

                this.Hide();
                frmLvlone frmLvlone = new frmLvlone();

                frmLvlone.Show();
            }
            else if (level == 1)
            {

                this.Hide();
                frmLvltwo frmLvltwo = new frmLvltwo();

                frmLvltwo.Show();
            }
            else if (level == 2)
            {

                this.Hide();
                frmLvlthree frmLvlthree = new frmLvlthree();

                frmLvlthree.Show();
            }
            else if (level == 3)
            {

                this.Hide();
                frmLvlfour frmLvlfour = new frmLvlfour();

                frmLvlfour.Show();
            }
            else if (level == 4)
            {

                this.Hide();
                frmLvlfive frmLvlfive = new frmLvlfive();

                frmLvlfive.Show();
            }
            else if (level == 5)
            {

                this.Hide();
                frmLvlfin frmLvlfin = new frmLvlfin();

                frmLvlfin.Show();
            }
            else if (level == 6)
            {

                this.Hide();
                frmMain frmMain = new frmMain();

                frmMain.Show();
            }


        }

        private void picContinue_MouseMove(object sender, MouseEventArgs e)
        {
            picContinue.Image = Properties.Resources.ContinueP;
        }

        private void picContinue_MouseLeave(object sender, EventArgs e)
        {
            picContinue.Image = Properties.Resources.ContinueU;
        }
    }
}
