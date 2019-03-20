using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Exercise
    {
        /// <summary>
        /// Adattagok létrehozása: public, private, protected
        /// Public : nyilvános elérés
        /// Private : csak az osztály számára látszik
        /// </summary>
        public string name;

        //Konstruktor: Inicializáljaaz osztály adattagjait 
        public Exercise(string aName)
        {
            name = aName;
        }

        //Tagfügvény
        public void PrintName()
        {
            Console.WriteLine(name);
        }
        // Másik tagfüggvény
        public string getName()
        {
            return name;
        }
      

    }
}
