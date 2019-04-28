using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write((j+1)*(i+1) + " ");
                    if ((j + 1) * (i + 1)<=10)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");

            }
            Console.Read();
        }
    }
}
