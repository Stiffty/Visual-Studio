using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public int B_Size = 25;
        public static int grigsize = 30;
        public  int[,] Feld = new int[grigsize, grigsize];
        

        public Form1()
        {
            InitializeComponent();
            
            for (int i = 0; i < grigsize; i++)
            {
                for (int j = 0; j < grigsize; j++)
                {
                    Button b = new Button();
                    b.Click += ButtenClick;
                    b.MouseMove += ButtenMove;
                    b.MouseDown += ButtenDClick;
                    b.Size = new Size(B_Size, B_Size);
                    b.Location = new Point((i * B_Size), (j * B_Size));
                    b.Show();
                    this.Controls.Add(b);
                    
                }
            }
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
               
                    Feld[rand.Next(grigsize - 1), rand.Next(grigsize - 1)] = -1;
                
            }
            
             
            for (int i = 0; i < grigsize; i++)
            {
                for (int j = 0; j < grigsize; j++)
                {
                    if (Feld[i,j] != -1) {
                        Feld[i,j] = 0;
                        
                            try
                            {
                            if (Feld[i, j - 1] == -1)
                            {
                                Feld[i, j]++;
                            }
                        }
                            catch 
                            {

                               
                            }
                        try
                        {
                            if (Feld[i, j + 1] == -1)
                            {
                                Feld[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Feld[i-1, j] == -1)
                            {
                                Feld[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Feld[i + 1, j] == -1)
                            {
                                Feld[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Feld[i + 1, j+1] == -1)
                            {
                                Feld[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Feld[i - 1, j - 1] == -1)
                            {
                                Feld[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Feld[i + 1, j - 1] == -1)
                            {
                                Feld[i, j]++;
                            }
                        }
                        catch
                        {


                        }
                        try
                        {
                            if (Feld[i - 1, j + 1] == -1)
                            {
                                Feld[i, j]++;
                            }
                        }
                        catch
                        {


                        }


                    }

                }
            
            }
        }
        
        private void ButtenDClick(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            int x = b.Location.X / B_Size;
            int y = b.Location.Y / B_Size;
            b.Text = "B";
            b.BackColor = Color.Blue;
        }

        private void ButtenClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int x=b.Location.X / B_Size;
            int y = b.Location.Y / B_Size;
            b.Text = (Feld[x,y]).ToString();
            b.BackColor = Color.Red;
        }
       private void ButtenMove(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int x = b.Location.X / B_Size;
            int y = b.Location.Y / B_Size;
            if (Feld[x, y] == 0)
            {
                b.Text = (Feld[x, y]).ToString();
                b.BackColor = Color.Red;
            }
        }
    }
}
