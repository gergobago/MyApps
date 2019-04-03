using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    abstract class Animal
    {
        protected string Name;
        protected bool isFemale;

        abstract public void Sleep();
        abstract public void Hunt();
        abstract public void Sound();
        abstract public void Born(int i);
    }

    //Feladat: kölyök nevelés osztály szinten
    class Cat : Animal
    {

        private List<Cat> Kids;

        public Cat(string aName, bool aGender)
        {
            Name = aName;
            isFemale = aGender;
        }

        public override Born(int v)
        {
            if (isFemale)
            {
                Kids = new List<Cat>();
                for (int i = 0; i < v; i++)
                {
                    Kids.Add(new Cat("Mirci" + i.ToString(), true));
                }
            }
        }

        public void Child()
        {

            if (Kids != null)
            {

                foreach (var item in Kids)
                {
                    Console.WriteLine(Name + "'s child name: " + item.Name);
                }
            }
        }


        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping....");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is hunting....");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + " is meowin....");
        }

        public override void Born()
        {
            Console.WriteLine(Name + " kölykö(ke)t szült....");
        }
    }

    class Dog : Animal
    {
        private List<Dog> Kids;

        public Dog(string aName, bool aGender)
        {
            Name = aName;
            isFemale = aGender;
        }

        public override void Born(int v)
        {
            Kids = new List<Dog>();
            for (int i = 0; i < v; i++)
            {
                Kids.Add(new Dog("Gyuri" + i.ToString(),true));
            }
        }

        public void Child()
        {
            if (Kids != null)
            {

                foreach (var item in Kids)
                {
                    Console.WriteLine(Name + "'s child name: " + item.Name);
                }
            }
        }
        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping....");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is Hunting....");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + " is barking....");
        }

        public override void Born()
        {
            Console.WriteLine(Name + " nem szült kölyköt....");
        }
    }
}

