using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int random;
            int bereich = 100;
            int anzahl = 100000;
            double duchschnitt;
            int[] zeit = new int[bereich];
            int[] zeit1 = new int[bereich];
            int[] zeit2 = new int[bereich];
            int[] zeit3 = new int[bereich];
            int [] zahl = new int[bereich];

            

            for (int i = 0; i < anzahl; i++)
            {
                Random rand = new Random();
                random = rand.Next(0,bereich);
                zahl[random]++;
                zeit[random] = DateTime.Now.Millisecond;
                if (zeit[random] == 0)
                {
                    zeit1[random] = DateTime.Now.Millisecond;
                }
                if (zeit1[random] == 0)
                {
                    zeit2[random] = DateTime.Now.Millisecond;
                }
                if (zeit2[random] == 0)
                {
                    zeit3[random] = DateTime.Now.Millisecond;
                }
               



            }
            for (int j = 0; j < bereich; j++)
            {
           
                Console.WriteLine(j + 1 + " " + zahl[j]+ "  " + ((zahl[j]*100) / anzahl ) + "%" + "  "+ zeit[j] + "  " + zeit1[j] + "  " + zeit2[j] + "  " + zeit3[j]);
            }
            Console.ReadLine();
        }
    }
}
