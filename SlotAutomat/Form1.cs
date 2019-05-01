using System;
using System.Media;
using System.Windows.Forms;

namespace SlotAutomat
{
    public partial class Form1 : Form
    {
        private double konto = 100000;
        private double einsatz = 1;
        private int skip = 0;
        private System .ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        public Form1 ( )
        {
            InitializeComponent ( );
            Random rand = new Random();
            label2.Text = ( konto ).ToString ( );
            label4.Text = ( einsatz ).ToString ( );
            label8.Text = " ";
        }

        private void button1_Click ( object sender,EventArgs e )
        {
            label8.Text = " ";
            losung ( );
            gewinne ( );

        }



        public void gewinne ( )
        {
            if ( konto <= 0 )
            {
                MessageBox.Show ( "Du Hast kein Geld mehr!!" );
                Close ( );
            }

            Random rand = new Random();
            double random = rand.Next(1, 650);

            konto -= einsatz;

            if ( random >= 325 )
            {
                panel4.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_O;
                panel5.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_O;
                panel6.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_O;

            }
            if ( random == 1 || random == 2 )
            {
                panel4.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_O;
                panel5.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_O;
                panel6.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_O;

            }
            if ( random == 1000 )
            {
                panel4.BackgroundImage = global::SlotAutomat.Properties.Resources._7_O;
                panel5.BackgroundImage = global::SlotAutomat.Properties.Resources._7_O;
                panel6.BackgroundImage = global::SlotAutomat.Properties.Resources._7_O;

            }
            if ( random >= 8 && random <= 15 )
            {
                panel4.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_O;
                panel5.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_O;
                panel6.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_O;

            }

            panel4.BackgroundImage = global::SlotAutomat.Properties.Resources._7_O;
            panel5.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_O;
            panel6.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_O;

            if ( random >= 325 )
            {
                panel1.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_M;
                panel2.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_M;
                panel3.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_M;
                konto += einsatz * 5;
                label8.Text = "Mal 5";
                blinker ( );
            }
            if ( random == 1 || random == 2 )
            {
                panel1.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_M;
                panel2.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_M;
                panel3.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_M;
                konto += einsatz * 50;
                label8.Text = "Mal 50";
                blinker ( );
            }
            if ( random == 1000 )
            {
                panel1.BackgroundImage = global::SlotAutomat.Properties.Resources._7_M;
                panel2.BackgroundImage = global::SlotAutomat.Properties.Resources._7_M;
                panel3.BackgroundImage = global::SlotAutomat.Properties.Resources._7_M;
                konto += einsatz * 250;
                label8.Text = "Mal 250";
                blinker ( );
                MessageBox.Show ( "Sie Haben Den Jackpot geknackt!!" );
            }
            if ( random >= 8 && random <= 15 )
            {
                panel1.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_M1;
                panel2.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_M1;
                panel3.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_M1;
                konto += einsatz * 10;
                label8.Text = "Mal 10";
                blinker ( );
            }
            label2.Text = ( konto ).ToString ( );
        }


        public static void wait ( int milliseconds )
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if ( milliseconds == 0 || milliseconds < 0 )
            {
                return;
            }

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start ( );
            timer1.Tick += ( s,e ) =>
            {
                timer1.Enabled = false;
                timer1.Stop ( );
            };
            while ( timer1.Enabled )
            {
                Application.DoEvents ( );
            }
        }





        private void textBox1_TextChanged ( object sender,EventArgs e )
        {
            skip = int.Parse ( textBox1.Text );
        }


        private void button2_Click ( object sender,EventArgs e )
        {
            losung ( );
            for ( int i = 0 ; i < skip ; i++ )
            {
                gewinne ( );
            }
        }


        private void losung ( )
        {
            Random rand = new Random();
            double last;
            int mitte = 3;
            int mitte2 = 0;
            int oben;
            int unten = 1;
            int swich = 0;

            button1.Enabled = false;

            oben = rand.Next ( 1,4 );
            last = oben;

            label2.Text = ( konto ).ToString ( );

            if ( konto <= 0 )
            {
                MessageBox.Show ( "Du Hast kein Geld mehr!!" );
                Close ( );
            }

            button1.Enabled = false;

            for ( int i = 0 ; i < 25 ; i++ )
            {
                oben = rand.Next ( 1,4 );
                while ( last == oben && last == unten && last == mitte )
                {
                    oben = rand.Next ( 1,4 );
                }
                last = oben;



                //oben
                if ( oben == 1 )
                {
                    panel4.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_O;
                    panel5.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_O;
                    panel6.BackgroundImage = global::SlotAutomat.Properties.Resources._7_O;
                }
                if ( oben == 2 )
                {
                    panel4.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_O;
                    panel5.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_O;
                    panel6.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_O;

                }
                if ( oben == 3 )
                {
                    panel4.BackgroundImage = global::SlotAutomat.Properties.Resources._7_O;
                    panel5.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_O;
                    panel6.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_O;
                }
                if ( oben == 4 )
                {
                    panel4.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_O;
                    panel5.BackgroundImage = global::SlotAutomat.Properties.Resources._7_O;
                    panel6.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_O;
                }



                //mitte
                if ( mitte == 1 )
                {
                    panel1.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_M;
                    panel2.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_M1;
                    panel3.BackgroundImage = global::SlotAutomat.Properties.Resources._7_M;
                }
                if ( mitte == 2 )
                {
                    panel1.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_M1;
                    panel2.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_M;
                    panel3.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_M;

                }
                if ( mitte == 3 )
                {
                    panel1.BackgroundImage = global::SlotAutomat.Properties.Resources._7_M;
                    panel2.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_M;
                    panel3.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_M;
                }
                if ( mitte == 4 )
                {
                    panel1.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_M;
                    panel2.BackgroundImage = global::SlotAutomat.Properties.Resources._7_M;
                    panel3.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_M1;
                }


                mitte = oben;

                //unten
                if ( unten == 1 )
                {
                    panel7.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_U;
                    panel8.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_U;
                    panel9.BackgroundImage = global::SlotAutomat.Properties.Resources._7_U;
                }
                if ( unten == 2 )
                {
                    panel7.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_U;
                    panel8.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_U;
                    panel9.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_U;

                }
                if ( unten == 3 )
                {
                    panel7.BackgroundImage = global::SlotAutomat.Properties.Resources._7_U;
                    panel8.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_U;
                    panel9.BackgroundImage = global::SlotAutomat.Properties.Resources.Orange_U;
                }
                if ( unten == 4 )
                {
                    panel7.BackgroundImage = global::SlotAutomat.Properties.Resources.Zitrone_U;
                    panel8.BackgroundImage = global::SlotAutomat.Properties.Resources._7_U;
                    panel9.BackgroundImage = global::SlotAutomat.Properties.Resources.Kirsche_U;
                }
                unten = mitte2;

                if ( swich == 0 )
                {
                    swich = 1;
                }
                else
                {
                    mitte2 = mitte;
                }

                wait ( 100 );



            }
            button1.Enabled = true;
        }
        private void button3_Click ( object sender,EventArgs e )
        {
            if ( einsatz > 0 )
            {
                einsatz--;
                label4.Text = ( einsatz ).ToString ( );
            }
        }

        private void button4_Click ( object sender,EventArgs e )
        {
            if ( einsatz <= konto )
            {
                einsatz++;
                label4.Text = ( einsatz ).ToString ( );
            }
        }

        private void button5_Click ( object sender,EventArgs e )
        {
            einsatz = konto;
            label4.Text = ( einsatz ).ToString ( );
        }
        private void blinker ( )
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Slot.wav");

            simpleSound.Play ( );
            wait ( 3500 );
            simpleSound.Stop ( );


        }

        private void button6_Click ( object sender,EventArgs e )
        {
            skip = 0;
        }
    }
}

