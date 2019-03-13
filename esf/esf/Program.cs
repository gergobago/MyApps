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
            //A létrehozott  új típussal inicializálunk egy objektumot
            Exercise ex = new Exercise("Bagó Gergő");

            //ex.name = "Bagó Gergő";


            //Public adattagot elérjük
            Console.WriteLine(ex.name);

            //Tagfügvény meghívása
            ex.PrintName();

            Console.WriteLine(ex.getName());

            //Beolvas egy karaktert a konzolról
            Console.ReadKey();

            
        }
    }
}
