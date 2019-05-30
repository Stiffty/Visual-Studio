using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Folge
{
    class Program
    {
        static void Main(string[] args)
        {
            folge(0,1,4000);
            Console.Read();
        }

        public static void folge(BigInteger a,BigInteger b,BigInteger end)
        {

            if ( end == 0 )
            {

            }
            else
            {
                folge(b,a += b,end -= 1);
                Console.WriteLine(b);
                
            }

        }

    }
}
