using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mapgenerator
{
    public partial class Form1 : Form
    {
        public Button[,] Buttons = new Button[70, 70];
        private int[,] feld = new int[70, 70];
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            generation();
        }

        private void generation()
        {
            for (var i = 0; i < 70; i++)
            for (var j = 0; j < 70; j++)
            {
                var b = new Button();
                //b.Click += ;
                //b.MouseDown += ButtenDClick;
                b.Size = new Size(30, 30);

                b.Location = new Point(i * 20, j * 20);
                b.Show();
                Buttons[i, j] = b;
                Controls.Add(b);
            }
        }
    }
}