using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotAutomat
{
    public partial class Form1 : Form
    {
        private double konto = 100000;
        private double einsatz = 0;
        private int skip = 0;
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            label2.Text = (konto).ToString();
            label4.Text = (einsatz).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = " ";
            losung();
            gewinne();
        }

       

        public void gewinne()
        {
            if (konto <=0)
            {
                MessageBox.Show("Du Hast kein Geld mehr!!");
                this.Close();
            }

            Random rand = new Random();
            double random = rand.Next(1,650);

            if (random >= 325)
            {
                panel1.BackColor = Color.Yellow;
                panel2.BackColor = Color.Yellow;
                panel3.BackColor = Color.Yellow;
                konto += einsatz*0.5;
                label6.Text = "Mal 0,5";
            }
            if (random == 1 || random == 2)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
                panel3.BackColor = Color.Red;
                konto += einsatz * 50;
                label6.Text = "Mal 50";
            }
            if (random >= 4 && random <= 7)
            {
                panel1.BackColor = Color.Blue;
                panel2.BackColor = Color.Blue;
                panel3.BackColor = Color.Blue;
                konto += einsatz * 25;
                label6.Text = "Mal 25";
            }
            if (random == 1000)
            {
                panel1.BackColor = Color.Gold;
                panel2.BackColor = Color.Gold;
                panel3.BackColor = Color.Gold;
                konto += einsatz * 250;
                label6.Text = "Mal 250";
                MessageBox.Show("Sie Haben Den Jackpot geknackt!!");
            }
            if (random >= 8 && random <= 15)
            {
                panel1.BackColor = Color.Green;
                panel2.BackColor = Color.Green;
                panel3.BackColor = Color.Green;
                konto += einsatz * 5;
                label6.Text = "Mal 5";
            }
            label2.Text = (konto).ToString();
        }


        public static void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = (trackBar1.Value).ToString();
            einsatz = trackBar1.Value;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            skip = int.Parse(textBox1.Text);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            losung();
            for (int i = 0; i < skip; i++)
            {
                konto -= einsatz;
                gewinne();
            }
        }


        private void losung()
        {
            Random rand = new Random();
            double last;
            double random;


            random = rand.Next(1, 4);
            last = random;
            konto -= einsatz;
            label2.Text = (konto).ToString();

            if (konto <= 0)
            {
                MessageBox.Show("Du Hast kein Geld mehr!!");
                this.Close();
            }
            button1.Enabled = false;
            for (int i = 0; i < 15; i++)
            {
                random = rand.Next(1, 4);
                while (last == random)
                {
                    random = rand.Next(1, 4);
                }
                last = random;

                if (random == 1)
                {
                    panel1.BackColor = Color.Green;
                    panel2.BackColor = Color.Blue;
                    panel3.BackColor = Color.Red;
                }
                if (random == 2)
                {
                    panel1.BackColor = Color.Blue;
                    panel2.BackColor = Color.Green;
                    panel3.BackColor = Color.Yellow;

                }
                if (random == 3)
                {
                    panel1.BackColor = Color.Red;
                    panel2.BackColor = Color.Yellow;
                    panel3.BackColor = Color.Green;
                }
                if (random == 4)
                {
                    panel1.BackColor = Color.Yellow;
                    panel2.BackColor = Color.Red;
                    panel3.BackColor = Color.Blue;
                }
                wait(100);

            }
            button1.Enabled = true;
        }
        public void anzahl()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\elach\\SlotAutomat.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        
    }
}
