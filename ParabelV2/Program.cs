using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParabelV2
{
    class Program
    {
        private static float[,] P1 = new float[10, 10];
        private static float[,] P2 = new float[10, 10];
        private static float[,] P3 = new float[10, 10];
        private static float[,] P4 = new float[10, 10];
        private static float x;
        private static float Expo = 2;
        private static float y = 1;
        static void Main(string[] args)
        {
            while (Hoch()<10)
            {
                x = Hoch();
                P1[(int)x-1, (int)y-1] = 1;
                P2[(int)x - 1, (int)y - 1] = 1;
                y++;
            }
            for (float i = 0; i < 10; i++)
            {
                Console.WriteLine("");
                for (float j = 0; j < 10; j++)
                {
                    if (P1[9 - (int)i, 9 - (int)j] == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    
                }
                Console.Write("*");
                for (float j = 0; j < 10; j++)
                {
                    if (P2[9 - (int)i, (int)j] == 0)
                    {
                        Console.Write(" ");
                    }
                    else {
                        Console.Write("*");
                    }

                    
                }
            }
            Console.WriteLine("");
            for (float i = 0; i < (10*2)+1; i++)
            {
                Console.Write("*");
            }
            Console.ReadLine();
        }

        public static float Hoch()
        {
            float ergebnis = y;
            for (float i = 0; i < Expo-1; i++)
            {
                ergebnis = ergebnis * y;
            }
            return ergebnis;
        }
    }
}
