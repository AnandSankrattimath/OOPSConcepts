using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPSConcepts
{
     class Father
    {
        int money = 10000;
        public void getMoney()
        {
            Console.WriteLine(money);
        }
    }

    class Child : Father
    {
        static void Main()
        {
            Child child = new Child();
            child.getMoney();
        }
    }
}
