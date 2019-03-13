using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 0;



            //A létrehozott  új típussal inicializálunk egy objektumot
            Exercise ex = new Exercise("Bagó Gergő");

            //ex.name = "Bagó Gergő";


            //Public adattagot elérjük
            Console.WriteLine(ex.name);

            //Tagfügvény meghívása
            ex.PrintName();

            //Ezt kellene megoldani
            Console.WriteLine(ex.getName());

            ///Ciklusok

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ciklus:<Változó hivatkozás I.>" + i);
                Console.WriteLine("Ciklus: {0}", i);
            }

            v = 0;
            while (v>0)
            {
                Console.WriteLine("While ciklus");
                v--;
            }

            //Do-while: Hátultesztelős ciklus
            v = 2;
            do
            {
                Console.WriteLine("Do While Ciklus");
                v--;
            } while (v>0);

            //Beolvas egy karaktert a konzolról
            Console.ReadKey();

            
        }
    }
}
