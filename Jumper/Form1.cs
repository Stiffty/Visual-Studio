using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jumper
{
    public partial class Form1 : Form
    {
        private int x = 730;
        private int y = 300;
        private Panel[] Pa = new Panel[800];


        public Form1()
        {
            InitializeComponent();
            generat();
        }

        private void button1_Click(object sender,EventArgs e)
        {
            
            x = 730;
            y = 300;
           
        }



        public static void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if ( milliseconds == 0 || milliseconds < 0 )
            {
                return;
            }

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s,e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while ( timer1.Enabled )
            {
                Application.DoEvents();
            }
        }

       /* private void Form1_KeyDown(object sender,KeyEventArgs e)
        {
            int x = 124;
            int y = 260;
            if (e.KeyCode == Keys.A)
            {
                y -=30;
                panel2.Location = new System.Drawing.Point(x,y);
               wait(1000);

                y += 30;
                panel2.Location = new System.Drawing.Point(x,y);
            }
        }*/

        public void generat()
        {
            int x = 10;
            for (int i = 0; i < 80; i++)
            {
                Panel P = new Panel
                {
                    Size = new Size(10, 170),
                    Location = new Point((x), (170)),
                    BackColor = Color.Black
                    
                };
                P.Show();
                Controls.Add(P);
                
                for (int j = x; j < x+10; j++)
                {
                    Pa[j] = P;
                }
                x += 10;
            }
        }
        public void test(Panel P )
        {
            
            if(Pa[x] != null)
            {
                Pa[x].Location = new System.Drawing.Point(x, 170+20);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 800;
            }
            else
            {
                x -= 10;
            }
            panel3.Location = new System.Drawing.Point(x, y);
           
        }
    }
}
