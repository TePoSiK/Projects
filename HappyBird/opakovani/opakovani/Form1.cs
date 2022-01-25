using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opakovani
{
    public partial class Form1 : Form
    {

        public int score = 0;
        
        public bool gameOver = false;

        int rychlostSkakani = 5;
        int rychlostDopredu = 1;
        int maxUp = 5;
        int maxDown = 550;
        int newLocation1;
        int newLocation2;

        bool nahoru;
        bool Up = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            nahoru = false;
            pbBird.Image = Properties.Resources.main2;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            nahoru = true;
            pbBird.Image = Properties.Resources.main1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nahoru)
                pbBird.Top -= rychlostSkakani;
            else
                pbBird.Top += rychlostSkakani;

            if (pbBird.Location.Y <= maxUp)
                pbBird.Top = maxUp;
            if (pbBird.Bottom >= maxDown)
                pbBird.Top = maxDown - pbBird.Height;

            pbHorniTrubka.Left -= rychlostDopredu;
            pbDolniTrubka.Left -= rychlostDopredu;
            pbHorniHlava.Left -= rychlostDopredu;
            pbDolniHlava.Left -= rychlostDopredu;
            
            

            if (pbHorniTrubka.Right < 0 && pbHorniTrubka.Right < 0)
            {
                score++;
                pbHorniTrubka.Left = panel1.Width;
                pbHorniHlava.Left = panel1.Width - 5;

                pbDolniTrubka.Left = panel1.Width;
                pbDolniHlava.Left = panel1.Width - 5;

                label1.Text = "Score: " + score;

                newPosition();
            }

            endCheck();
        }

        private void startBtn_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zrychleni.Enabled = true;
            startBtn.Visible = false;
            pauseBtn.Visible = true;
        }

        private void endCheck()
        {
            if (pbBird.Bounds.IntersectsWith(pbHorniHlava.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbHorniTrubka.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbDolniHlava.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbDolniTrubka.Bounds))
            {
                timer1.Enabled = false;
                gameOver = true;
                button3.Visible = true;
            }
        }

        private void newPosition()
        {
            Random rPlus = new Random();
            Random rMinus = new Random();

            newLocation1 = rPlus.Next(1, pbHorniHlava.Location.Y - 5);
            newLocation2 = rMinus.Next(1, (panel1.Height - pbDolniHlava.Location.Y - 5));


            if (Up)
            {
                pbHorniHlava.Top -= newLocation1;
                pbHorniTrubka.Top -= newLocation1;
                pbDolniHlava.Top -= newLocation1;
                pbDolniTrubka.Top -= newLocation1;
                Up = false;
            }
            else
            {
                pbHorniHlava.Top += newLocation2;
                pbHorniTrubka.Top += newLocation2;
                pbDolniHlava.Top += newLocation2;
                pbDolniTrubka.Top += newLocation2;
                Up = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (timer1.Enabled == true)
                {
                    timer1.Enabled = false;
                    zrychleni.Enabled = false;
                    pauseBtn.Text = "▷";
                } else
                {
                    timer1.Enabled = true;
                    zrychleni.Enabled = true;
                    pauseBtn.Text = "| |";
                }
            }
        }

        private void zrychleni_Tick(object sender, EventArgs e)
        {
            rychlostDopredu++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rekordy rekordy = new Rekordy(this);
            rekordy.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Vysledky vysledky = new Vysledky(this);
            vysledky.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
