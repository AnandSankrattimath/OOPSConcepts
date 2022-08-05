using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPSConcepts
{
    class Animal
    {
        int noOfLegs = 4;
        public void walk()
        {
            Console.WriteLine("Animals can walk with " + noOfLegs + " legs");
        }
    }

    class Human
    {
        int noOfLegs = 2;
        public void walk()
        {
            Console.WriteLine("Humans can walk with " + noOfLegs + " legs");
        }

    }

    class WalkingStatus
    {
        void Main()
        {
            Human human = new Human();
            human.walk();

            Animal animal = new Animal();
            animal.walk();
        }
    }
}
