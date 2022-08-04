using BasicOOPSConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPSConcepts
{
    public class Citizen  // Creating class
    {
        int id;
        String name;
        String address;
        Boolean isEmployee;

        public void saveDetails( int id,String name,String address,Boolean isEmployee) // method/function with parameters
        {
            Console.WriteLine("saveDetails() started");
            this.id = id;
            this.name = name;
            this.address = address;
            this.isEmployee = isEmployee; // value initialization.
            Console.WriteLine("Successfully details saved...");
        }

       

        public void getDetails() // method/function without parameter.
        {
            Console.WriteLine("getDetails() started");
            Console.WriteLine("Name of citizen is {0}", name);
            Console.WriteLine("Address of citizen is "+address); 
            Console.WriteLine("Details were displayed...");
        }

    } 
}
class ObjectCreation
{
    static void Main()
    {
        Citizen manish = new Citizen();
        manish.saveDetails(111, "Manish Mullur", "Bagalkot", true);
        manish.getDetails();
        Console.ReadLine();
    }
}
