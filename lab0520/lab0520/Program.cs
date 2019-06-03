using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0520
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[15];
            //
             string[] sArray = new string[5];
            //
            int[] iT = new int[] { 5, 8, 9 };
            //
            int[][] iT2 = new int[][]
                {
                    new int[] { 4,5 },
                     new int[] { 2,3 },
                      new int[] { 6,8 }                              
                };
            //
            int[,] iT3 = new int[,] { { 4, 5 }, { 2, 3 }, { 6, 8 } };
            Console.WriteLine(iT3[ 0,1 ]);
            try
            {
                Console.WriteLine(iT3[1, 1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //
            int[,,] iT4 = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            //try
           // {
           //     Console.WriteLine(iT4[1, 2, 1]);
          //  }
           // catch (Exception e)
           //{
             //  Console.WriteLine(e.Message);
          //  }
            //
            //for (int i = 0; i < 50; i++)
           // {
              //  if ((i%3)== 0)
               // {
                 //   Console.WriteLine(i);
               // }

           // }

            //Feladat:50-ig a prímszámok
            int[] szamok = new int[30];
            Random rnd = new Random();
            int min = 1, max = 100, i, j, k, m, n;
            bool b = true;
            for (i = 0; i < 30; i++)
            {
                do
                {
                    j = i - 1;
                    k = rnd.Next(min, max);
                    while (j > -1)
                    {
                        if (k == szamok[j])
                        {
                            k = 0;
                            j = 0;
                        }
                        j--;
                    }
                    if (k > 0)
                    {
                        szamok[i] = k;
                        b = true;
                        if (k != 2)
                        {
                            if (k < 2 || (k % 2) == 0) b = false;
                            else
                            {
                                m = 3;
                                n = (int)Math.Sqrt(k);
                                while (m <= n && b)
                                {
                                    if ((k % m) == 0) b = false;
                                    m += 2;
                                }
                            }
                        }
                    }
                } while (k == 0);
                Console.WriteLine(k + ":    " + (b ? "Prímszám." : "Nem Prímszám."));
            }
            Console.ReadLine();
        }
    }
}


