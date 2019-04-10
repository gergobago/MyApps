using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipuskonverziok
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;

            if (x is int) //is operátort használunk
            {
                Console.WriteLine("x típusa int");
            }
            else
            {
                Console.WriteLine("Az x típusa nem int");
            }

            object a = "123";
            object b = "Hello";
            object c = 10;
            string aa = a as string;
            //expr1 ? v1 : v2;
            Console.WriteLine(aa == null ? "NULL" : aa); // 123 

            string bb = b as string;
            Console.WriteLine(bb == null ? "NULL" : bb); // Hello 

            string cc = c as string;
            Console.WriteLine(cc == null ? "NULL" : cc); // NULL 

            //expr1 ? v1 : v2;
            int f = 10;
            Console.WriteLine(x == 5 ? "f==5":"f != 5");

            //Karakter konverziók
            for (char ch = 'a'; ch <= 'z'; ++ch)
            {
                Console.Write(ch + "->" + (int)ch + " ");
            }

            //Tömbök
            int iPrev = 0;
            int[] iTomb = new int[3];
            Random r = new Random();
            for (int i = 0; i < iTomb.Length; i++)
            {
                //konzolról kérje be a számot
                Console.WriteLine();
                Console.Write("Kérem a {0}. számot: ", i);
                try
                {
                    iTomb[i] = int.Parse(Console.ReadLine());
                    iPrev = i;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hiba." + e.Message);
                    i = iPrev;
                }

               // iTomb[i] = r.Next();
            }

            Console.WriteLine();
            //Kiiratni az iTomb elemeit
            for (int i = 0; i < iTomb.Length; i++)
            {
                Console.Write(iTomb[i] + " ");
            }

            //Tömb kezdeti értékeinek megadása int[]; string[]
            int[] iArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] sArr = new string[] { "alma", "banán", "körte", "mangó" };


            Array.Sort(sArr);
            //Kiiratni az sArr elemeit
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.Write(sArr[i] + " ");
            }

            Array.Sort(iArr);
            //Kiiratni az iArr elemeit
            for (int i = 0; i < iArr.Length; i++)
            {
                Console.Write(iArr[i] + " ");
            }

            //TöbbDimenziós Tömb

            int[,] matrix = new int[,]
                {
                    {12, 23, 2},
                    {13, 67, 52},
                    {45, 55, 1},
                };

            Console.ReadKey();
        }
    }
}
