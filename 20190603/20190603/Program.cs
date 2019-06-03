using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _stringback

{
    class Program
    {
        static void Main(string[] args)
        {

            string str;

            Console.Write("Kérem a szöveget: ");

            //Bekértük az adatot
            str = Console.ReadLine();

            

            Console.WriteLine("Szöveg visszafelé:" + StrBck(str));
            //Feladat:Írjunk függvényt, ami a bekért szöveg hosszát kiírja

            Console.WriteLine("A szöveg hossza: " + CharCount(str));

            Console.WriteLine(ChangeChar('e', 'x', str));

            Console.ReadKey();
            
        }

         static string ChangeChar(char v1, char v2, string str)
        {
            string s;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == v1)
                {
                    s = s + v2;
                }
                else
                {
                    s = s + str[i];
                }return s;
            }
        }

        static int CharCount(string str)
        {
           return str.Length;
        }

        static string StrBck(string str)
         {
            //Lokális változó létrehozása

            string s = "";

            for (int i = str.Length -1; i >= 0; i--)
            {
                s = s + str[i];
            }

            return s;
         }

        
    }
}
