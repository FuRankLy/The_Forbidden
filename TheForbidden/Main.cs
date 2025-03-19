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
    public partial class frmMain : Form
    {
        public static int level;
        public frmMain()
        {
            InitializeComponent();
        }

        private void picPlay_MouseLeave(object sender, EventArgs e)
        {
            picPlay.Image = Properties.Resources.PlayU;
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            level = 0;
            this.Hide();
            frmLoad frmLoad = new frmLoad();

            frmLoad.Show();
        }

        private void picPlay_MouseMove(object sender, MouseEventArgs e)
        {
            picPlay.Image = Properties.Resources.PlayPressed;
        }
        private void picHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp frmHelp = new frmHelp();
            frmHelp.Show();
        }

        private void picHelp_MouseLeave(object sender, EventArgs e)
        {
            picHelp.Image = Properties.Resources.HelpUN;
        }

        private void picHelp_MouseMove(object sender, MouseEventArgs e)
        {
            picHelp.Image = Properties.Resources.HelpP;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.ExitUnPRESSED;
        }

        private void picExit_MouseMove(object sender, MouseEventArgs e)
        {
            picExit.Image = Properties.Resources.EXITPRESSED;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            picTitle.BackColor = Color.Transparent;
            picPlay.BackColor = Color.Transparent;
            picHelp.BackColor = Color.Transparent;
            picExit.BackColor = Color.Transparent;
            picTitle.Parent = picBackground;
            picPlay.Parent = picBackground;
            picHelp.Parent = picBackground;
            picExit.Parent = picBackground;
        }
    }
}
