using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat myCat = new Cat("Lilla");
            myCat.Sleep();
            myCat.Hunt();
            myCat.Sound();
            myCat.Born(999999);
            myCat.Child();
            

            Dog myDog = new Dog("Shea");
            myDog.Sleep();
            myDog.Hunt();
            myDog.Sound();
            myDog.Born(999999);
            myDog.Child();

            Console.ReadKey();
            
        }
    }
}
