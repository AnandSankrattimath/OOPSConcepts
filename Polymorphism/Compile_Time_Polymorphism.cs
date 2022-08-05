using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPSConcepts
{
     class Addition
    {
        

       public void add(int number1,int number2)
        {
            int total = number1 + number2;

            Console.WriteLine("Addition of two numbers is " + total);
        }

        public void add(String firstName,String secondName)
        {
            String concate = firstName + secondName;   
            Console.WriteLine("String concatenation is "+concate);
        }

        void Main()
        {
            Addition addition = new Addition();
            addition.add(1, 2);
            addition.add("Anand","Sankrattimath");
        }
    }

}
