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
            ///2.Feladat
            ///Változók létrehozása
            string compChoice = "";
            string playerChoice = "";

            int copmScore = 0;
            int playerScore = 0;

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
                ///Feladat 3:
                ///Player választásának megkérdezése és tárolása
                ///n
                Console.Write("Mit választasz? k/p/o ");
                switch (Console.ReadKey(true).KeyChar)

                {
                    case 'k':
                        playerChoice = "kő";
                        break;
                    case 'p':
                        playerChoice = "papír";
                        break;
                    case 'o':
                        playerChoice = "olló";
                        break;
                }
                



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
