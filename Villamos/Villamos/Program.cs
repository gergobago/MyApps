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
            int P = U * I;
            double kW = P * 0.001 ;
            double mW = kW * 0.001;



            Console.WriteLine("Kérem adja mag az U értékét: ");
            U = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Kérem adja mag az I értékét: ");
            I = int.Parse(Console.ReadLine());
            Console.WriteLine();

            P=U*I;

            Console.WriteLine("A teljesítmény (P) értéke: ");
            Console.Write(P);
            Console.WriteLine();

            kW=P*0.001;

            Console.WriteLine("A teljesítmény (P) értéke kW-ban: ");
            Console.Write(kW);
            Console.WriteLine();

            mW=kW*0.001;

            Console.WriteLine("A teljesítmény (P) értéke mW-ban: ");
            Console.Write(mW);
            Console.WriteLine();



            Console.ReadKey();

            

        }
    }
}
