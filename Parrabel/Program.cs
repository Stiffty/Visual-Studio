using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrabel
{
    class Program
    {
        private static int xK = 10;
        private static int yK = 10;
        private static int x = 9;
        private static int y = 1;
        private static int Variable = 1;
        private static int Exponent = 2;
        private static int[,] posi = new int[xK,yK];
        
        static void Main(string[] args)
        {
            
            int a = 100;
            for (int i = 0; i < a; i++)
            {
                if (Hoch()>9)
                {
                    a = 0;
                }
                else { 
                  x = Hoch();
                  posi[x, y] = 1;
                  y++;
                 
                }
                
            }
            


            for (int i = 0; i < 10; i++)
            {
               


                for (int j = 0; j < 10; j++)
                {

                    
                    if (posi[xK-(j+1), yK - (i+1)] == 1)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.Write("*");
                for (int k = 0; k < xK; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < (xK*2); i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            for (int i = 0; i < yK; i++)
            {


                for (int j = 0; j < xK; j++)
                {
                    Console.Write(" ");

                }
                Console.Write("*");
                for (int k = 0; k < xK; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        public static int Hoch()
        {
            int ergebnis = y;
            for (int i = 0; i < Exponent-1; i++)
            {
                ergebnis = ergebnis * y;
            }
            return ergebnis;
        }
    }
}
