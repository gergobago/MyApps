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
            //Fruit1[] Fruits = new Fruit1[15];

            var fruits = new List<Fruit1>();

            string nev;
            string szarmazasihely;
            int mennyiseg;
            int gyumolcs;
            int osszmenny = 0;


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

                osszmenny += mennyiseg;



                //Fruits[i] = new Fruit1(nev, szarmazasihely, mennyiseg);
                fruits.Add(new Fruit1(nev, szarmazasihely, mennyiseg));

                Console.WriteLine("Gyümölcsök összes mennyisége: " + osszmenny);


                fruits[i].nev = nev;
                fruits[i].szarmazasihely = szarmazasihely;
                fruits[i].mennyiseg = mennyiseg;

            }
            Console.WriteLine("A gyümölcsös tartalma: ");
            for (int i = 0; i < gyumolcs; i++)
            {
                Console.WriteLine(fruits[i].nev);
                Console.WriteLine(fruits[i].szarmazasihely);
                Console.WriteLine(fruits[i].mennyiseg);

                Console.ReadKey();

          


            }
        }
    }
}

