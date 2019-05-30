using System;
using System.Windows.Forms;
using TikTakToe.Properties;

namespace TikTakToe
{
    public partial class Form1 : Form
    {
        public int[,] Feld = new int[3, 3];
        public int Player = 1;
        public int test;

        public Form1()
        {
            InitializeComponent();
        }

        public bool Endtest()
        {
            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
                if (Feld != null && (Feld[i, j] != 1 && Feld[i, j] != 2))
                    return true;
            MessageBox.Show("Unendschieden");
            return false;
        }

        public void Button(int x, int y, object sender, EventArgs e)
        {
            var b = sender as Button;

            if (test == 0)
            {
                if (Player == 1)
                {
                    b.BackgroundImage = Resources.XTik1;
                    Feld[x, y] = 1;
                    Player = 2;
                }
                else if (Player == 2)
                {
                    b.BackgroundImage = Resources.OTik1;
                    Feld[x, y] = 2;
                    Player = 1;
                }

                b.Enabled = false;
                if (!WinTest() || !Endtest()) test = 1;
            }
        }

        public bool WinTest()
        {
            var CounterP1y = 0;
            var CounterP2y = 0;
            var CounterP1x = 0;
            var CounterP2x = 0;
            var CounterP1q = 0;
            var CounterP2q = 0;
            var CounterP1q2 = 0;
            var CounterP2q2 = 0;
            for (var i = 0; i < 3; i++)

            {
                if (CounterP1y == 3 || CounterP1x == 3)
                {
                    MessageBox.Show("P1 Gewinnt");
                    label1.Text = "XY1";
                    return false;
                }

                if (CounterP2y == 3 || CounterP2x == 3)
                {
                    MessageBox.Show("P2 Gewinnt");
                    label1.Text = "XY2";
                    return false;
                }

                CounterP1y = 0;
                CounterP2y = 0;
                CounterP1x = 0;
                CounterP2x = 0;

                for (var j = 0; j < 3; j++)
                {
                    if (Feld[i, j] == 1)
                        CounterP1y++;
                    else if (Feld[i, j] == 2) CounterP2y++;
                    if (Feld[j, i] == 1)
                        CounterP1x++;
                    else if (Feld[j, i] == 2) CounterP2x++;

                    if (CounterP1y == 3 || CounterP1x == 3)
                    {
                        MessageBox.Show("P1 Gewinnt");
                        label1.Text = "XY1";
                        return false;
                    }

                    if (CounterP2y == 3 || CounterP2x == 3)
                    {
                        MessageBox.Show("P2 Gewinnt");
                        label1.Text = "XY2";
                        return false;
                    }

                    if (i == 0 && j == 0 || i == 1 && j == 1 || i == 2 && j == 2)
                    {
                        if (Feld[i, j] == 1)
                            CounterP1q++;
                        else if (Feld[i, j] == 2) CounterP2q++;
                    }
                    else if (i == 0 && j == 2 || i == 1 && j == 1 || i == 2 && j == 0)
                    {
                        if (Feld[i, j] == 1)
                            CounterP1q2++;
                        else if (Feld[i, j] == 2) CounterP2q2++;
                    }
                }
            }

            if (CounterP1q == 3 || CounterP1q2 == 3)
            {
                MessageBox.Show("P1 Gewinnt");
                label1.Text = "Q1";
                return false;
            }

            if (CounterP2q == 3 || CounterP2q2 == 3)
            {
                MessageBox.Show("P2 Gewinnt");
                label1.Text = "Q2";
                return false;
            }


            return true;
        }

        public void neustart()
        {
            test = 0;
            for (var i = 0; i < 3; i++)
            for (var j = 0; j < 3; j++)
                Feld[i, j] = 0;

            foreach (Control formControl in Controls)
            {
                if (!(formControl is Button button)) continue;
                button.Enabled = true;
                button.BackgroundImage = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button(0, 0, sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button(0, 1, sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button(0, 2, sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button(1, 0, sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button(1, 1, sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button(1, 2, sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button(2, 0, sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button(2, 1, sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button(2, 2, sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            neustart();
        }
    }
}