using System;
using System.Drawing;
using System.Windows.Forms;

namespace PacmenV1
{
    public partial class Form1 : Form
    {
        private int y = 240;
        private int x = 360;
        private int swich = 0;
        private static int xK = 700;
        private static int yK = 700;
        private int [,] PositionZiele = new int[700,700];
        private Panel [,] panels = new Panel[700,700];
        private int [,]wandPosition = new int[xK/10,yK/10];
        private Bitmap N = Properties.Resources.pacOffenN;
        private Bitmap S = Properties.Resources.pacOffenS;
        private Bitmap O = Properties.Resources.pacOffen;
        private Bitmap W = Properties.Resources.pacOffenW;

        //test
        private int testS = 0;
        private int testW = 0;
        private int testN = 0;
        private int testO = 0;
        //

        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(this.FormMouseMove);
            this.MouseDown += new MouseEventHandler(this.FormMouseDown);
            generation();
        }

        private void Form1_KeyDown(object sender,KeyEventArgs e)
        {


            if ( e.KeyCode == Keys.S )
            {
                //Test
                label1.Text = "S";
                label2.Text = ( testS ).ToString();
                testS++;
                //

                if ( y < yK-20 )
                {
                    y += 10;
                    Animation(1);
                }
                else
                {
                    y = 0;
                }
                //Size: 37; 31
                Zieltest();
                panel1.Location = new System.Drawing.Point(x,y);


            }
            else

            if ( e.KeyCode == Keys.W )
            {
                //Test
                label1.Text = "W";
                label2.Text = ( testW ).ToString();
                testW++;
                //
                if ( y > 0 )
                {
                    y -= 10;
                    Animation(2);
                }
                else
                {
                    y = yK-20;
                }
                Zieltest();
                panel1.Location = new System.Drawing.Point(x,y);
            }
            else
            if ( e.KeyCode == Keys.A )
            {
                //Test
                label1.Text = "A";
                label2.Text = ( testN ).ToString();
                testN++;
                //
                if ( x > 0 )
                {
                    x -= 10;
                    Animation(3);
                }
                else
                {
                    x = xK-20;
                }
                Zieltest();
                panel1.Location = new System.Drawing.Point(x,y);
            }
            else
            if ( e.KeyCode == Keys.D )
            {
                //Test
                label1.Text = "D";
                label2.Text = ( testO ).ToString();
                testO++;
                //
                if ( x < xK-20 )
                {
                    x += 10;
                    Animation(4);
                }
                else
                {
                    x = 0;
                }
                Zieltest();
                panel1.Location = new System.Drawing.Point(x,y);
            }
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


        private void Animation(int Richtung)
        {
            switch ( Richtung )
            {
                case 1:
                    if ( swich == 0 )
                    {
                        swich = 1;
                        panel1.BackgroundImage = N;
                    }
                    else
                    {
                        swich = 0;
                        panel1.BackgroundImage = Properties.Resources.PacZU;
                        wait(0);
                    }
                    break;
                case 2:
                    if ( swich == 0 )
                    {
                        swich = 1;
                        panel1.BackgroundImage = S;
                    }
                    else
                    {
                        swich = 0;
                        panel1.BackgroundImage = Properties.Resources.PacZU;
                        wait(0);
                    }
                    break;
                case 3:
                    if ( swich == 0 )
                    {
                        swich = 1;
                        panel1.BackgroundImage = W;
                    }
                    else
                    {
                        swich = 0;
                        panel1.BackgroundImage = Properties.Resources.PacZU;
                        wait(0);
                    }
                    break;
                case 4:
                    if ( swich == 0 )
                    {
                        swich = 1;
                        panel1.BackgroundImage = O;
                    }
                    else
                    {
                        swich = 0;
                        panel1.BackgroundImage = Properties.Resources.PacZU;
                        wait(0);
                    }
                    break;

            }

        }

        private void generation()
        {
            int x;
            int y;

            for ( int i = 0 ; i < 6 ; i++ )
            {
                x = rand.Next(0,xK-20);
                y = rand.Next(0,yK-20);
                Panel P = new Panel
                {
                    Size = new Size(10,10),
                    Location = new Point(( x ),( y )),
                    BackgroundImage = Properties.Resources.Erdbeere
                };
                P.Show();
                panels[x,y] = P;
                int ys = y;
                int xs = x;
                for ( int a = 0 ; a < 10 ; a++ )
                {
                    y = ys;
                    for ( int j = 0 ; j < 10 ; j++ )
                    {
                        PositionZiele[x,y] = 1;
                        y++;
                    }
                    x++;
                }
                PositionZiele[xs,ys] = 2;
                Controls.Add(P);
            }
        }

        private void Zieltest()
        {
            int xa = x;
            int ya = y;
            for ( int i = 0 ; i < 20 ; i++ )
            {
                ya = y;
                for ( int j = 0 ; j < 20 ; j++ )
                {

                    if ( PositionZiele[xa,ya] == 2 )
                    {
                        panels[xa,ya].BackgroundImage = null;
                    }


                    ya++;
                }
                xa++;

            }
        }

         private void wand()
        {
            
        }

        private void toolStripMenuItem1_Click(object sender,EventArgs e)
        {

        }

        private void beeToolStripMenuItem_Click(object sender,EventArgs e)
        {
            Application.Exit();
        }



        private Point mousePosition;

        /// <summary>
        /// Verarbeitet das MouseDown-Event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Mouse-Event Argumente</param>
        private void FormMouseDown(object sender,System.Windows.Forms.MouseEventArgs e)
        {
            this.mousePosition = new Point(-e.X,-e.Y);
        }

        /// <summary>
        /// Verarbeitet das MouseMove-Event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Mouse-Event Argumente</param>
        private void FormMouseMove(object sender,System.Windows.Forms.MouseEventArgs e)
        {
            // Wenn der Linke Button gedrückt ist
            if ( e.Button == MouseButtons.Left )
            {
                // Maus-Position auf dem Control
                Point mousePos = Control.MousePosition;

                // Verschiebt den Punkt um den angegebenden Betrag
                mousePos.Offset(this.mousePosition.X,this.mousePosition.Y);

                // Neue Position setzen
                this.Location = mousePos;
            }
        }
    }
}
