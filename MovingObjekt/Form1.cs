using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingObjekt
{
    public partial class Form1 : Form
    {
        private int y = 213;
        private int x = 346;
        public Form1()
        {
            InitializeComponent();

        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                if (y <= 600)
                {
                    y += 10;
                }
                //Size: 37; 31
                panel1.Location = new System.Drawing.Point(x, y);
            }

            if (e.KeyCode == Keys.W)
            {
                if (y > 10)
                {
                    y -= 10;
                }

                panel1.Location = new System.Drawing.Point(x, y);
            }
            if (e.KeyCode == Keys.A)
            {
                if (x > 5 )
                {
                    x -= 10;
                }

                panel1.Location = new System.Drawing.Point(x, y);
            }
            if (e.KeyCode == Keys.D)
            {
                if (x <= 740)
                {
                    x += 10;
                }

                panel1.Location = new System.Drawing.Point(x, y);
            }
        }
    }
}

