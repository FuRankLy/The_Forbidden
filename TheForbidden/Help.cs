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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            picBackPressed.Hide();
            picBackUnpressed.BackColor = Color.Transparent;
            picBackPressed.BackColor = Color.Transparent;        
            picInstructions.BackColor = Color.Transparent;
            picSpace.BackColor = Color.Transparent;
            picSpace.Parent = picInstructions;
            picBoost.BackColor = Color.Transparent;
            picBoost.Parent = picInstructions;
            picDoNotTouch.BackColor = Color.Transparent;
            picDoNotTouch.Parent = picInstructions;
            picGrab.BackColor = Color.Transparent;
            picGrab.Parent = picInstructions;
            picSuperJump.BackColor = Color.Transparent;
            picSuperJump.Parent = picInstructions;
            picLetter.BackColor = Color.Transparent;
            picLetter.Parent = picInstructions;
            picPlant.BackColor = Color.Transparent;
            picPlant.Parent = picInstructions;
            picAD.BackColor = Color.Transparent;
            picAD.Parent = picInstructions;
            //foreach (PictureBox x in this.Controls)
            //{


            //    if (x is PictureBox && (string)x.Tag == "x")
            //    {
            //        x.BackColor = Color.Transparent;
            //        x.Parent = picInstructions;
            //    }
            //}
        }
        private void picBackPressed_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
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

        private void picBackUnpressed_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
