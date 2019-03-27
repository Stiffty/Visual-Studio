using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tannenbaum
{
    class Program
    {
        public Program()
        {


            Random rand = new Random();
            while (true)
            {
                int leer = 10;
                int stern = 1;
                int test = 1;
                int random = 0;

                while (test == 1)
                {
                    for (int i = 0; i < leer; i++)
                    {
                        random = rand.Next(5);
                        if (random == 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }


                    }
                    for (int j = 0; j < stern; j++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 0; i < leer; i++)
                    {
                        random = rand.Next(5);
                        if (random == 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");

                    leer--;
                    stern += 2;
                    if (leer == 0)
                    {
                        test = 0;
                    }

                }
                Thread.Sleep(100);
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
