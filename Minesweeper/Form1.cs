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
        public int fertig = 0;
        public int richtigB = 0;
        public int B_Size = 25;
        public static int grigsize = 10;
        public static int bomben = 10;
        public  int[,] Feld = new int[grigsize, grigsize];
        public Button[,] Buttons = new Button[grigsize, grigsize];


        public Form1()
        {
            InitializeComponent();
            grigsize = Program.grigsize;
            bomben = Program.bomben;
            Feld = new int[grigsize, grigsize];
            Buttons = new Button[grigsize, grigsize];
            B_Size = 800 / grigsize;
            Size = new Size(new Point((int)((grigsize + 0.5) * B_Size), ((int)(grigsize + 0.5) * B_Size) + 42));
           

            for (int i = 0; i < grigsize; i++)
            {
                for (int j = 0; j < grigsize; j++)
                {
                    Button b = new Button();
                    b.Click += ButtenClick;
                    b.MouseDown += ButtenDClick;
                    b.Size = new Size(B_Size, B_Size);
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", B_Size / 3, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Location = new Point((i * B_Size), (j * B_Size));
                    b.Show();
                    Buttons[i, j] = b;
                    this.Controls.Add(b);
                    
                }
            }
            Random rand = new Random();
            for (int i = 0; i < bomben; i++)
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
            if (e.Button == MouseButtons.Right)
            {
                
                b.BackColor = Color.Blue;
                b.Text = "B";
            }
            if (Feld[x,y] ==-1)
            {
                richtigB++;
            }else
            {
                fertig++;
            }
            
        }

        private void ButtenClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int x = b.Location.X / B_Size;
            int y = b.Location.Y / B_Size;
            if (b.Enabled)
            {
                b.Enabled = false;
                if (Feld[x, y] == 0)
                {
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            try
                            {
                                if (Buttons[x + i, y + j].Enabled)
                                    ButtenClick(Buttons[x + i, y + j], e);
                                    b.BackColor = Color.Gray;
                                Update();
                            }
                            catch { }
                        }
                    }
                }
                else if (Feld[x,y] == -1)
                {
                    MessageBox.Show("Du Hast Verloren!!", "BOOOM");
                    
                }
                else
                {
                    b.Text = (Feld[x, y]).ToString();
                    b.BackColor = Color.Green;
                }


            }
            b.Enabled = false;
            if (b.Text=="B")
            {
                fertig--;
            }
        }
       
    }
}
