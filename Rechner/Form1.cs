using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechner
{
    public partial class Form1 : Form
    {
        public double eingabe;
        public double prozess;
        public String eingabeA;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonBelegung (object sender)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonBelegung(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //+
            prozess = 1;
            eingabeA = textBox1.Text;
            textBox1.Text = "";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //-
            prozess = 2;
            eingabeA = textBox1.Text;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //AC
            textBox1.Text = "";
            eingabeA = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //=
            if (prozess == 1)
            {
                textBox1.Text = (double.Parse( eingabeA) + double.Parse(textBox1.Text)).ToString();

            }else if (prozess == 2)
            {
                textBox1.Text = (double.Parse(eingabeA) - double.Parse(textBox1.Text)).ToString();
                
            }else if (prozess ==3)
            {
                textBox1.Text = (double.Parse(eingabeA)  * double.Parse(textBox1.Text)).ToString();
            }
            else if (prozess == 4)
            {
                textBox1.Text = (double.Parse(eingabeA) / double.Parse(textBox1.Text)).ToString();
            }else if (prozess == 5)
            {
                String eingabeB = eingabeA;
                for (int i = 1; i < double.Parse(textBox1.Text); i++)
                {
                    eingabeB = (double.Parse(eingabeB) * double.Parse(eingabeA)).ToString();
            }
                textBox1.Text = (double.Parse(eingabeB)).ToString();
            }
           
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //*
            prozess = 3;
            eingabeA = textBox1.Text;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // /
            prozess = 4;
            eingabeA = textBox1.Text;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // ^
            prozess = 5;
            eingabeA = textBox1.Text;
            textBox1.Text = "";
        }
    }
}
