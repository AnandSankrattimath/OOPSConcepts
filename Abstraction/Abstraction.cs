using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPSConcepts
{
   abstract class Car
    {
     public void canDrive()
        {
            Console.WriteLine("You can drive this car");
        }
       public abstract void getName();

    }

    class Tata : Car
    {
        string name = "Tata Harrier";
        public override void getName()
        {
            Console.WriteLine(" Car name is " + name);
        }
    }

    class Mahindra : Car
    {
        string name = "Mahindra Scorpio";
        public override void getName()
        {
            Console.WriteLine(" Car name is " + name);
        }
    }

    class Running
    {
        void Main()
        {
            Mahindra mahindra = new Mahindra();
            mahindra.getName();
            mahindra.canDrive();

            Tata tata  = new Tata();
            tata.canDrive();
            tata.getName();
        }
    }
}
