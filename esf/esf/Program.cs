using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 0;
            string  s;


            //A létrehozott  új típussal inicializálunk egy objektumot
            Exercise ex = new Exercise("Bagó Gergő");

            //ex.name = "Bagó Gergő";


            //Public adattagot elérjük
            Console.WriteLine(ex.name);

            //Tagfügvény meghívása
            ex.PrintName();

            //Ezt kellene megoldani
            Console.WriteLine(ex.getName());

            ///Ciklusok

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ciklus:<Változó hivatkozás I.>" + i);
                Console.WriteLine("Ciklus: {0}", i);
            }

            v = 0;
            while (v>0)
            {
                Console.WriteLine("While ciklus");
                v--;
            }

            //Do-while: Hátultesztelős ciklus
            v = 2;
            do
            {
                Console.WriteLine("Do While Ciklus");
                v--;
            } while (v>0);

            //Elágazások
            v = 2;
            if (v == 2)
            {
                Console.WriteLine("A v értéke egyenlő 2vel");
            }
            else if (v == 3)
            {
                Console.WriteLine("A v értéke egyenlő 3val");
            }
            else
            {
                Console.WriteLine("A v értéke nem 2 és nem 3, hanem:" + v);
            }
            //Elágazások: switch
            v = 76;
            switch (v)
            {
                case 0:
                    Console.WriteLine("Switch:" + v);
                    break;
                case 5:
                    Console.WriteLine("Switch:" + v);
                    break;
                default:
                    Console.WriteLine("Switch default:" + v);
                    break;

            }

            //Egy billentyű leütése
            // Console.Readkey(true).KeyChar
            //integerré konvertálni a console számot(string)
            //int.Parse(Console.Readline())


            //Tömbök
            //Létrhoztunk egy tömböt aminek a neve 'szamok'
            int[] szamok = new int[5];
            string[] szovegek = new string[10];

            //Tömb inicializálás
            int[] iNums = new int[] { 1,2,3,4,5,6};
            string[] sFruit = new string[] {"Alma","Körte","Banán","Narancs"};
            Console.WriteLine("iNums első eleme: {0} sFruit első eleme: {1}", iNums[0], sFruit[0]);
            Console.WriteLine("iNums első eleme:" + iNums[0] + "  sFruit első eleme:" + sFruit[0]);

            //Típusos listák
            //Lista elem
            List<Book> Lista = new List<Book>();

            //Új elemek hozzáadása a listához
            //Ctrl-'.' hívhatjuk segítségül
            Lista.Add(new Book() { Name = "Oroszlánkölykök", Author = "IrwinShaw", Page = 100 });
            Lista.Add(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });
            Lista.Add(new Book() { Name = "Egri csillagok", Author = "Gárdonyi Géza", Page = 1200 });

            
            //Lista kiiratása
            foreach  (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }

            //Lista egy elemének törlése
            Lista.Remove(Lista.Find(x => x.Name.Contains("Megkergetve")));
            Lista.Remove(Lista.Find(x => x.Name.Contains("Oroszlánkölykök")));

            Console.WriteLine("******************************************************************");
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }

            //Feladat: Egészítsük ki a programot úgy hogy a felhasználó engedélyt kap arra hogy kiválassza a 'u','t','l' közül
            bool moreBook = true;
            string sName;
            String sAuthor;
            int iPage;

            Console.WriteLine("Üdvözöllek a könyvtáramban");


            do
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Válassz az u(Új könyv) /t(Egyik könyv törlése) /l(Könyvek kilistázása) /k(Könyvtár bezárása) közül: ");
                Console.WriteLine("--------------------------");


                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'u':
                        Console.WriteLine("Kérem a könyv címét: ");
                        sName = Console.ReadLine();

                        Console.WriteLine("Kérem a könyv szerzőjét: ");
                        sAuthor = Console.ReadLine();

                        Console.WriteLine("Kérem a könyv lapszámát: ");
                        iPage = int.Parse(Console.ReadLine());
                        Lista.Add(new Book { Name = sName, Author = sAuthor, Page = iPage });
                        break;
                    case 'k':
                        moreBook = false;
                        break;
                    case 't':
                        Console.WriteLine("Kérem a könyv címét: ");
                        sName = Console.ReadLine();

                        Lista.Remove(Lista.Find(x => x.Name.Contains(sName)));
                        break;
                    case 'l':
                        Console.WriteLine("Könyvtár tartalma: ");
                        foreach (Book book in Lista)
                        {
                            Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
                        }
                        break;

                } 






            }while(moreBook) ;

            
            //Console.WriteLine("Keressük az Oroszlánkölykök könyvet:" + Lista.Find(x => x.Name.Contains("Oroszlánkölykök")).Name);

            //Beolvasás konzolról
            // s = Console.ReadLine();
            //Console.WriteLine("Beolvasás konzolról:" + s);



            //Beolvas egy karaktert a konzolról
            //Console.ReadKey();


        }
    }
}
