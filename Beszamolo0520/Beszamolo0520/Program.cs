using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beszamolo0520
{
    class Program
    {
        static void Main(string[] args)
        {
            //adatok Kilistázása

            int[] iArray = new int[10];
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                iArray[i] = r.Next(100);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(iArray[i]);
            }


            Elemek obj = new Elemek(5, "Szöveg");
            obj.Lista();



            Console.WriteLine("Beszámoló 2019.05.20!");
            Console.ReadKey();

        }
    }
}
