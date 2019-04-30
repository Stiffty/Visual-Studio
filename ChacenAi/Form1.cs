using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChacenAi
{
    public partial class Form1 : Form
    {
        private double konto = 50;
        private double einsatz = 1;
        private int gewinner = 0;
        private int verlierer = 0;
        private int besser = 0;
        private double bank = 0;

        private double[] MaxK = new double[1000];
        private double[] Speicher = new double[42];

        private double G1;
        private double G2;
        private double G3;
        private double G4;
        private double C1_1 = 1;
        private double C1_2 = 0;
        private double C2_1 = 1;
        private double C2_2 = 0;
        private double C3_1 = 1;
        private double C3_2 = 0;
        private double C4_1 = 1;
        private double C4_2 = 0;

        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double test = 0;
            ersteGenerierung();

            for (int i = 0; i < 1000; i++)
            {
                MaxK[i] = simulation();
                if (MaxK[i] > test)
                {
                    test = MaxK[i];
                }
                progressBar1.Value = +1;
                label33.Text = (bank).ToString();
            }
            label1.Text = (test).ToString();
            ausgabe();
        }

        private double simulation()
        {
            double random;
            double KontoMax = 0;

            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                konto = 50;
                
                for (int j = 0; j < int.Parse(textBox2.Text); j++)
                {
                    random = rand.Next(1, 1000);
                    konto -=einsatz;
                    bank =+einsatz;

                    if (random >= C1_1 && random <= C1_2)
                    {
                        //1-50
                        konto = +G1;
                        bank -= G1;
                    }
                    else
                    if (random >= C2_1 && random <= C2_2)
                    {
                        //50-200
                        konto = +G2;
                        bank -= G2;
                    }
                    else
                    if (random >= C3_1 && random <= C3_2)
                    {
                        //200-500
                        konto = +G3;
                        bank -= G3;
                    }
                    else
                    if (random >= C4_1 && random <= C4_2)
                    {
                        //500-1000
                        konto = +G4;
                        bank -= G4;
                    }
                    
                }
                if (konto > KontoMax)
                {
                    KontoMax = konto;
                }

                if (konto>50)
                {
                    gewinner++;
                }
                else
                {
                    verlierer++;
                }
                
            }
            return KontoMax;
        }


        private void ersteGenerierung()
        {
            while (C1_1>=C1_2)
            {
                C1_1 = rand.Next(1,50);
                C1_2 = rand.Next(1, 50);
                G4 = rand.Next(1, 50);
            }
            while (C2_1 >= C2_2)
            {
                C2_1 = rand.Next(51, 200);
                C2_2 = rand.Next(51, 200);
                G3 = rand.Next(51, 200);
            }
            while (C3_1 >= C3_2)
            {
                C3_1 = rand.Next(201, 500);
                C3_2 = rand.Next(201, 500);
                G2 = rand.Next(201, 500);
            }
            while (C4_1 >= C4_2)
            {
                C4_1 = rand.Next(501, 1000);
                C4_2 = rand.Next(501, 1000);
                G1 = rand.Next(501, 1000);
            }
           einsatz = rand.Next(1, 50);
        }

        private void ausgabe()
        {
            label6.Text = (einsatz).ToString();
            label19.Text = (G1).ToString();
            label20.Text = (G2).ToString();
            label21.Text = (G3).ToString();
            label22.Text = (G4).ToString();

            label23.Text = (C1_1).ToString();
            label24.Text = (C1_2).ToString();
            label25.Text = (C2_1).ToString();
            label26.Text = (C2_2).ToString();
            label27.Text = (C3_1).ToString();
            label28.Text = (C3_2).ToString();
            label29.Text = (C4_1).ToString();
            label30.Text = (C4_2).ToString();
            label31.Text = (gewinner).ToString();
            label32.Text = (verlierer).ToString();
            label33.Text = (bank).ToString();

        }

        private int EinsONull(int x)
        {
            if (besser == 1) {
                if (Speicher[x] == 0)
                {
                    return 0;
                } else
                {
                    return 1;
                }
            }
            else
            {
                return rand.Next(0,1);
            }
           
        }

        private void auswertung()
        {
            int winnerP = int.Parse(textBox4.Text);
            int Gewinn = int.Parse(textBox3.Text);

            if (Gewinn == konto&&(gewinner*100)/ int.Parse(textBox1.Text) == winnerP)
            {

            
            }
            if ()
            {

            }
        }

    
        private void anpassung()
        {
            if (EinsONull(10)== 0)
            {
                C1_1 = +0.1;
                Speicher[10] = 0;
            }
            else
            {
                Speicher[10] = 1;
                C1_1 = -0.1;
            }

            if (EinsONull(11) == 0)
            {
                C1_2 = +0.1;
                Speicher[11] = 0;
            }
            else
            {
                Speicher[11] = 1;
                C1_2 = +0.1;
            }

            if (EinsONull(20) == 0)
            {
                C2_1 = -0.1;
                Speicher[20] = 0;
            }
            else
            {
                Speicher[20] = 1;
                C2_1 = +0.1;
            }

            if (EinsONull(21) == 0)
            {
                C2_2 = +0.1;
                Speicher[21] = 0;
            }
            else
            {
               Speicher[21] = 1;
                C2_2 = -0.1;
            }

            if (EinsONull(30) == 0)
            {
                C3_1 = +0.1;
                Speicher[30] = 0;
            }
            else
            {
                Speicher[30] = 1;
                C3_1 = -0.1;
            }

            if (EinsONull(31) == 0)
            {
                C3_2 = +0.1;
                Speicher[31] = 0;
            }
            else
            {
                Speicher[31] = 1;
                C3_2 = -0.1;
            }

            if (EinsONull(40) == 0)
            {
                C4_1 = +0.1;
                Speicher[40] = 0;
            }
            else
            {
                Speicher[40] = 1;
                C4_1 = -0.1;
            }

            if (EinsONull(41) == 0)
            {
                C4_2 = +0.1;
                Speicher[41] = 0;
            }
            else
            {
                Speicher[41] = 1;
                C4_2 = -0.1;
            }

            if (EinsONull(0) == 0)
            {
                G1 = +0.1;
                Speicher[0] = 0;
            }
            else
            {
               Speicher[0] = 1;
                G1 = -0.1;
            }

            if (EinsONull(1) == 0)
            {
                G2 = +0.1;
                Speicher[1] = 0;
            }
            else
            {
                Speicher[1] = 1;
                G2 = -0.1;
            }

            if (EinsONull(2) == 0)
            {
                G3 = +0.1;
                Speicher[2] = 0;
            }
            else
            {
                Speicher[2] = 1;
                G3 = -0.1;
            }

            if (EinsONull(3) == 0)
            {
                G4 = +0.1;
                Speicher[3] = 0;
            }
            else
            {
                Speicher[3] = 1;
                G4 = -0.1;
            }

            if (EinsONull(4) == 0)
            {
                einsatz = +0.1;
                Speicher[4] = 1;
            }
            else
            {
                Speicher[4] = 1;
                einsatz = -0.1;
            }
        }

       
    }
}
