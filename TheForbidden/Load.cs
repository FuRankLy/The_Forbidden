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
    public partial class frmLoad : Form
    {
        int tick;

        public frmLoad()
        {
            InitializeComponent();
        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            picLoading.Parent = picBackground;
            picLoading.BackColor = Color.Transparent;
            picQuote.Parent = picBackground;
            picQuote.BackColor = Color.Transparent;


          
            var rand = new Random();
            //var list = new List<string> 

            //{ 

            //" 'If I were a tree, I would have no reason to love a human.' ",

            //"Forests are home to about 80% of the planet’s terrestrial animals and plants.",

            //"More than 50% of all the forest area on our planet is in just five countries.",

            //"The four main types of forests are Boreal, Temperate, Subtropical and Tropical.",

            //"Forests covered over 10 billion acres or 31% of the Earth’s landmass in 2020",

            //"Only 1.8 billion of the Earth’s 10 billion acres of forest are protected."

            //};

            int index = rand.Next(1,7);
            //lblFact.Text = list[index];
            if (index == 1)
            {
                picQuote.Image = Properties.Resources.Quote1;
            }
            if (index == 2)
            {
                picQuote.Image = Properties.Resources.Quote2;
            }
            if (index == 3)
            {
                picQuote.Image = Properties.Resources.Quote3;
            }
            if (index == 4)
            {
                picQuote.Image = Properties.Resources.Quote4;
            }
            if (index == 5)
            {
                picQuote.Image = Properties.Resources.Quote5;
            }
            if (index == 6)
            {
                picQuote.Image = Properties.Resources.Quote6;
            }
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {    
            tick++;
            if (tick == 50)
            {

                this.Hide();
                frmInfo frmInfo = new frmInfo();
                frmInfo.Show();            

            }
        }

        private void picBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
