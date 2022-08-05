using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPSConcepts
{
     class GrandMother
    {
        int jewels = 20;
        public void getJewels()
        {
            Console.WriteLine("GrandMother gives the  " +jewels+" jewels");
        }
    }

   class Mother : GrandMother
    {
        int money = 10;
        public void getMoney()
        {
            Console.WriteLine(" Mother gives the " + money + " money");
        } 
    }

    class Child1 : Mother
    {
        static void main()
        {
            Child1 child1 = new Child1();   
            child1.getJewels();
            child1.getMoney();
        }
    }
}
