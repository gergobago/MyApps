using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villamos
{
    class Program
    {
        static void Main(string[] args)
        {
            int U = 0 ;
            int I = 0 ;
            int R = U * I;
            double kW = R * 0.001 ;
            double mW = kW * 0.001;



            Console.WriteLine("Kérem adja mag az U értékét: ");
            U = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Kérem adja mag az I értékét: ");
            I = int.Parse(Console.ReadLine());
            Console.WriteLine();

            R=U*I;

            Console.WriteLine("A teljesítmény (R) értéke: ");
            Console.Write(R);
            Console.WriteLine();

            kW=R*0.001;

            Console.WriteLine("A teljesítmény (R) értéke kW-ban: ");
            Console.Write(kW);
            Console.WriteLine();

            mW=kW*0.001;

            Console.WriteLine("A teljesítmény (R) értéke mW-ban: ");
            Console.Write(mW);
            Console.WriteLine();



            Console.ReadKey();

            

        }
    }
}
