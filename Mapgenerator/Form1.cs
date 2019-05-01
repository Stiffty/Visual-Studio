using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapgenerator
{
    public partial class Form1 : Form
    {
        private int [,] feld = new int[70,70];
        public Button[,] Buttons = new Button[70, 70];
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            generation();
        }
        private void generation()
        {
            for ( int i = 0 ; i < 70 ; i++ )
            {
                for ( int j = 0 ; j < 70 ; j++ )
                {
                    Button b = new Button();
                    //b.Click += ;
                    //b.MouseDown += ButtenDClick;
                    b.Size = new Size(30,30);
                    
                    b.Location = new Point(( i * 20 ),( j * 20 ));
                    b.Show();
                    Buttons[i,j] = b;
                    this.Controls.Add(b);

                }
            }
        }
    }
}
