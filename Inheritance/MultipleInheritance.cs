using System;

namespace BasicOOPSConcepts
{
    class Parent1
    {
        public void eat()
        {
            Console.WriteLine("In Parent1 class");
        }
    }

    class Parent2
    {
        public void eat()
        {
            Console.WriteLine("In Parent2 class");
        }
    }

    /*class Child : Parent1, Parent2 // Compile time error i.e Child class does not have the multple base classes.
    {

    }*/

}
