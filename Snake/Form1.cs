using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private int Richtung = 0;
        private int lvl = 300;
        private int x = 300;
        private int y = 200;

        Panel[,] Panel = new Panel[800,800];

        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            ziel();
            timer1.Interval = lvl;
        }

        private void Form1_KeyDown(object sender,KeyEventArgs e)
        {


            if ( e.KeyCode == Keys.S )
            {
                Richtung = 2;
            }
            else

            if ( e.KeyCode == Keys.W )
            {
                Richtung = 0;
            }
            else
            if ( e.KeyCode == Keys.A )
            {
                Richtung = 3;
            }
            else
            if ( e.KeyCode == Keys.D )
            {
                Richtung = 1;
            }
        }

       
        private void timer1_Tick(object sender,EventArgs e)
        {
           

                if (!Zieltest())
                {
                    if (Richtung == 1)
                    {
                        x += 25;
                    }
                    else if (Richtung == 2)
                    {
                        y += 25;
                    }
                    else if (Richtung == 3)
                    {
                        x -= 25;
                    }
                    else if (Richtung == 0)
                    {
                        y -= 25;
                    }

                    panel1.Location = new System.Drawing.Point(x, y);

                }
                else
                {
                    Panel = new Panel[800,800];
                    lvl -= 10;
                    timer1.Interval = lvl;
                    ziel();
                }

            
        }

        public void ziel()
        {
            int x = rand.Next(0,775);
            int y = rand.Next(0,775);

            Panel P = new Panel
            {
                Size = new Size(25,25),
                Location = new Point(( x ),( y )),
                BackColor = Color.White
            };
            P.Show();
            Controls.Add(P);

            
                for ( int i = x ; i < ( x + 25 ) ; i++ )
                {
                    for ( int j = y ; j < ( y + 25 ) ; j++ )
                    {
                        Panel[i,j] = P;
                    }
                }
            
        }

       

        private Boolean Zieltest()
        {
            try
            {
                for ( int i = this.x ; i < ( x + 25 ) ; i++ )
                {
                    for ( int j = this.y ; j < ( y + 25 ) ; j++ )
                    {
                        if ( Panel[i,j] != null )
                        {
                            Controls.Remove(Panel[i,j]);
                            return true;
                        }
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }

}
