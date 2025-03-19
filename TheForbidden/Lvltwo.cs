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
    public partial class frmLvltwo : Form
    {
        bool goLeft = false; // boolean which will control players going left
        bool goRight = false; // boolean which will control players going right
        bool jumping = false; // boolean to check if player is jumping or not
        bool falling = true;

        int jumpSpeed = 13; // integer to set jump speed
        int force; // force of the jump in an integer
        int gravity = 9;
        int playSpeed = 4; //this integer will set players speed
        
        public frmLvltwo()
        {
            InitializeComponent();
           
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
 
            picBack.BackColor = Color.Transparent;
               
            picPlayer.BackColor = Color.Transparent;
           
            picJumpBoost.BackColor = Color.Transparent;
            
            picLetter.BackColor = Color.Transparent;

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfirm frmConfirm = new frmConfirm();
            frmConfirm.Show();
        }

        private void picBack_MouseLeave(object sender, EventArgs e)
        {
            picBack.Image = Properties.Resources.BACKUNPRESSED;
        }

        private void picBack_MouseMove(object sender, MouseEventArgs e)
        {
            picBack.Image = Properties.Resources.BACKPRESSED;
        }







        private void tmrMainGame_Tick(object sender, EventArgs e)
        {







            //if (jumping && force < 0)
            //{
            //    jumping = false;
            //}





            if (goLeft)
            {
                picPlayer.Left -= playSpeed;
            }
            if (goRight)
            {
                picPlayer.Left += playSpeed;
            }
            if (picPlayer.Bounds.IntersectsWith(picLetter.Bounds))
            {
                frmMain.level = 2;
                tmrMainGame.Stop();
                this.Hide();
                frmInfo frmInfo = new frmInfo();

                frmInfo.Show();
            }
            //if (picPlayer.Bounds.IntersectsWith(picJumpBoost.Bounds))
            //{

            //    force = 30;
            //    jumping = true;

            //}




            foreach (PictureBox x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "jumpboost")
                {
                    if (picPlayer.Bounds.IntersectsWith(picJumpBoost.Bounds))
                    {

                        force = 30;
                        jumping = true;

                    }
                }

                if (x is PictureBox && (string)x.Tag == "block")
                {
                    //top collision
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && picPlayer.Left + picPlayer.Width - 1 > x.Left && picPlayer.Left + picPlayer.Width + 5 < x.Left + x.Width + picPlayer.Width && picPlayer.Top + picPlayer.Height >= x.Top && picPlayer.Top < x.Top)
                    {
                        gravity = 9;
                        picPlayer.Top = (x.Top - picPlayer.Height);
                        falling = false;
                        jumping = false;
                        
                    }
                   
                            
                   
                   
                    
                    
                       
                    //side collision
                    while (picPlayer.Bounds.IntersectsWith(x.Bounds) && picPlayer.Right > x.Left && picPlayer.Left < x.Left)
                    {
                        //goRight = false;
                        picPlayer.Left = x.Left - picPlayer.Width;
                    }


                    while (picPlayer.Bounds.IntersectsWith(x.Bounds) && picPlayer.Left < x.Right && picPlayer.Right > x.Right)
                    {
                        //goLeft = false;
                        picPlayer.Left = x.Left + x.Width;
                    }



                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (picPlayer.Top <= x.Top + x.Height)
                        {
                            picPlayer.Top = x.Top + x.Height;
                            jumping = false;
                            //falling = true;
                            
                        }

                    }
                
                }
                if (x is PictureBox && (string)x.Tag == "bad")
                {


                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Hide();
                        tmrMainGame.Stop();
                        frmRetry frmRetry = new frmRetry();

                        frmRetry.Show();

                    }

                }
                

            }
            

        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                goRight = false;               
                picPlayer.Image = Properties.Resources.Character_Move_right__2_;
            }


            if (e.KeyCode == Keys.D)
            {

                goRight = true;
                goLeft = false;               
                picPlayer.Image = Properties.Resources.Character_Move_right__1_;

            }

            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
                force = jumpSpeed;
            }

        }

        private void frmGame_KeyUp(object sender, KeyEventArgs e)
        {
                            
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;                
                picPlayer.Image = Properties.Resources.Character_Left;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = false;                
                picPlayer.Image = Properties.Resources.Character_Right;
            }
           
        }

        private void tmrJump_Tick(object sender, EventArgs e)
        {
            if (jumping)
            {
                picPlayer.Top -= force;
                force -= 1;

            }
            else if (falling)

            {
                picPlayer.Top += gravity;
                gravity += 1;
            }

        }

        private void tmrWolf_Tick(object sender, EventArgs e)
        {
            falling = true;
        }

        
    }

}
