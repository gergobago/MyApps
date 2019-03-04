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
            Fruit1[] Fruits = new Fruit1[15];
            string nev;
            string szarmazasihely;
            int mennyiseg;
            int gyumolcs;

            Console.Write("Kérem a gyümölcsök számát: ");
            gyumolcs = int.Parse(Console.ReadLine());

            for (int i = 0; i < gyumolcs; i++)
            {

                Console.Write("Kérem a(z) {0}. Gyümölcs nevét: ", i + 1);
                nev = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. Gyümölcs származásihelyét: ", i + 1);
                szarmazasihely = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. Gyümölcs mennyiségét: ", i + 1);
                mennyiseg = int.Parse(Console.ReadLine());




                Fruits[i] = new Fruit1(nev, szarmazasihely, mennyiseg);

               
                Fruits[i].nev = nev;
                Fruits[i].szarmazasihely = szarmazasihely;
                Fruits[i].mennyiseg = mennyiseg;

            }
            Console.WriteLine("A gyümölcsös tartalma: ");
            for (int i = 0; i < gyumolcs; i++)
            {
                Console.WriteLine(Fruits[i].nev);
                Console.WriteLine(Fruits[i].szarmazasihely);
                Console.WriteLine(Fruits[i].mennyiseg);



                Console.ReadKey();


            }
        }
    }
}

