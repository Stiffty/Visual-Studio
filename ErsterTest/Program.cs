using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsterTest
{
    class Program
    {
        public Program()
        {
            //Console.WriteLine("Test");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j+1);
                }
            }
        }
        static void Main(string[] args)
        {
            new Program();
            
           // Console.WriteLine("Hello");
           Console.ReadLine(); 
        }

    }
}