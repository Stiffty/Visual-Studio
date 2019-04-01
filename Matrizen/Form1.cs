using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrizen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Subtraktion
            int min = (int.Parse(textBox18.Text));
            int max = int.Parse(textBox18.Text);
            textBox18.Text = (int.Parse(textBox1.Text) - int.Parse(textBox7.Text)).ToString();
            if (int.Parse(textBox18.Text) > int.Parse(textBox17.Text))
            {
                max = int.Parse(textBox17.Text);
            }
            if (int.Parse(textBox18.Text) < (int.Parse(textBox17.Text)))
            {
                min = int.Parse(textBox17.Text);
            }
            textBox17.Text = (int.Parse(textBox2.Text) - int.Parse(textBox8.Text)).ToString();
            if (int.Parse(textBox17.Text) > (int.Parse(textBox16.Text)))
            {
                max = int.Parse(textBox16.Text);
            }
            if (int.Parse(textBox17.Text) < (int.Parse(textBox16.Text)))
            {
                min = int.Parse(textBox16.Text);
            }
            textBox16.Text = (int.Parse(textBox3.Text) - int.Parse(textBox9.Text)).ToString();
            if (int.Parse(textBox16.Text) > (int.Parse(textBox15.Text)))
            {
                max = int.Parse(textBox15.Text);
            }
            if (int.Parse(textBox16.Text) < int.Parse(textBox15.Text))
            {
                min = int.Parse(textBox15.Text);
            }
            textBox15.Text = (int.Parse(textBox4.Text) - int.Parse(textBox10.Text)).ToString();
            if (int.Parse(textBox15.Text) > int.Parse(textBox14.Text))
            {
                max = int.Parse(textBox14.Text);
            }
            if (int.Parse(textBox15.Text) < (int.Parse(textBox14.Text)))
            {
                min = int.Parse(textBox14.Text);
            }
            textBox14.Text = (int.Parse(textBox5.Text) - int.Parse(textBox11.Text)).ToString();
            if (int.Parse(textBox14.Text) > (int.Parse(textBox13.Text)))
            {
                max = int.Parse(textBox13.Text);
            }
            if (int.Parse(textBox14.Text) < (int.Parse(textBox13.Text)))
            {
                min = int.Parse(textBox13.Text);
            }
            textBox13.Text = (int.Parse(textBox6.Text) - int.Parse(textBox12.Text)).ToString();
            if (int.Parse(textBox13.Text) > (int.Parse(textBox12.Text)))
            {
                max = int.Parse(textBox12.Text);
            }
            if (int.Parse(textBox13.Text) < (int.Parse(textBox12.Text)))
            {
                min = int.Parse(textBox12.Text);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Addition
            int min = int.Parse(textBox18.Text);
            int max = int.Parse(textBox18.Text);
            textBox18.Text = (int.Parse(textBox1.Text) + int.Parse(textBox7.Text)).ToString();
            if (int.Parse(textBox18.Text) > (int.Parse(textBox17.Text)))
            {
                max = int.Parse(textBox17.Text);
            }
            if (int.Parse(textBox18.Text) < (int.Parse(textBox17.Text)))
            {
                min = int.Parse(textBox17.Text);
            }
            textBox17.Text = (int.Parse(textBox2.Text) + int.Parse(textBox8.Text)).ToString();
            if (int.Parse(textBox17.Text) > (int.Parse(textBox16.Text)))
            {
                max = int.Parse(textBox16.Text);
            }
            if (int.Parse(textBox17.Text) < (int.Parse(textBox16.Text)))
            {
                min = int.Parse(textBox16.Text);
            }
            textBox16.Text = (int.Parse(textBox3.Text) + int.Parse(textBox9.Text)).ToString();
            if (int.Parse(textBox16.Text) > (int.Parse(textBox15.Text)))
            {
                max = int.Parse(textBox15.Text);
            }
            if (int.Parse(textBox16.Text) < (int.Parse(textBox15.Text)))
            {
                min = int.Parse(textBox15.Text);
            }
            textBox15.Text = (int.Parse(textBox4.Text) + int.Parse(textBox10.Text)).ToString();
            if (int.Parse(textBox15.Text) > (int.Parse(textBox14.Text)))
            {
                max = int.Parse(textBox14.Text);
            }
            if (int.Parse(textBox15.Text) < (int.Parse(textBox14.Text)))
            {
                min = int.Parse(textBox14.Text);
            }
            textBox14.Text = (int.Parse(textBox5.Text) + int.Parse(textBox11.Text)).ToString();
            if (int.Parse(textBox14.Text) > (int.Parse(textBox13.Text)))
            {
                max = int.Parse(textBox13.Text);
            }
            if (int.Parse(textBox14.Text) < (int.Parse(textBox13.Text)))
            {
                min = int.Parse(textBox13.Text);
            }
            textBox13.Text = (int.Parse(textBox6.Text) + int.Parse(textBox12.Text)).ToString();
            if (int.Parse(textBox13.Text) > (int.Parse(textBox12.Text)))
            {
                max = int.Parse(textBox12.Text);
            }
            if (int.Parse(textBox13.Text) < (int.Parse(textBox12.Text)))
            {
                min = int.Parse(textBox12.Text);
            }
        }
    }
}
