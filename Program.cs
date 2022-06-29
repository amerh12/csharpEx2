using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNaloga3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Krog k1 = new Krog();
            Krog k2 = new Krog();
            Random rd = new Random();
            
            double k1_double = k1.Obseg(20);
            double k2_double = k2.Obseg(rd.Next(5,32));

            if(k1_double > k2_double)
            {
                Console.WriteLine("k1 ({0}) je vecji od k2 ({1}) ", k1_double, k2_double);


            }
            else
            {
                Console.WriteLine("k2 ({0}) je vecji od k1 ({1}) ", k2_double, k1_double);
            }

        }
    }
}
