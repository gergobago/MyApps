using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Fruit1
    {

       public string nev;
       public string szarmazasihely;
       public int mennyiseg;
       
       



        //Konstruktor: minden objektum lehozásakor lefut
        public Fruit1(string anev, string aSzarmazasihely, int aMenny)
        {
            nev = anev;
            szarmazasihely = aSzarmazasihely;
            mennyiseg = aMenny;
        }

    }
}
