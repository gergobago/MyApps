using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpo1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Program: Kő papír olló játék leprogramozása
            ///Írta: Bagó Gergő / 2019.03.06.
            ///Adott: számítógép - véletlenszerűen választ k/p/o
            ///Játékos: Billentyűzettel választ

            ///1.Feladat
            ///Ciklus: Amíg a játékos szeretne játszani
            bool moreGame = true;

            Console.WriteLine("**********Kő/Papír/Olló**********");

            do
            {

                Console.Write("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }

            } while (moreGame);


            Console.ReadKey();

             
        }
    }
}
