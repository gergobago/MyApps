using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        private static int gyumolcs;

        static void Main(string[] args)
        {
            Fruit1[] myFruit1 = new Fruit1[5];
            string nev;
            string szarmazasihely;
            int mennyiseg;

            Console.Write("Kérem a gyümkölcsök számát: ");
            gyumolcs = int.Parse(Console.ReadLine());

            for (int i = 0; i < gyumolcs; i++)
            {

                Console.Write("Kérem a(z) {0}. Gyümölcs nevét: ", i + 1);
                nev = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. Gyümölcs származásihelyét: ", i + 1);
                szarmazasihely = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. Gyümölcs mennyiségét: ", i + 1);
                mennyiseg = int.Parse(Console.ReadLine());

                myFruit1[i] = new Fruit1();
                myFruit1[i].nev = nev;
                myFruit1[i].szarmazasihely = szarmazasihely;
                myFruit1[i].mennyiseg = mennyiseg;

            }
            Console.WriteLine("A gyümölcsös tartalma: ");
            for (int i = 0; i < gyumolcs; i++)
            {
                Console.WriteLine(myFruit1[i].nev);
                Console.WriteLine(myFruit1[i].szarmazasihely);
                Console.WriteLine(myFruit1[i].mennyiseg);

                Console.ReadKey();


            }
        }
    }
}

