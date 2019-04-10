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

            Console.ReadKey();
        }
    }
}
