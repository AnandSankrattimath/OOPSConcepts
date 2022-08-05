using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPSConcepts
{
     public class Government
    {
        String nameOfGovernment = "XYZ";
        int noOfMinisters=20;
        int noOfDepartments=20;

        public void getGovernmentDetails()
        {
            Console.WriteLine("Name of the Government " + nameOfGovernment + " Number of Minsiters are " + noOfMinisters + " Number of Departments " + noOfDepartments);
        }
    }

    class WaterDepartment : Government
    {
        string departmentName = "Water Department";
        int noOfEmploye = 10;
       public  WaterDepartment()
        {
            Console.WriteLine("Your are in " + departmentName + " department");

        }

    }

    class ElectricDepartment : Government
    {
        string departmentName = "Electric Department";
        int noOfEmploye = 10;
       public  ElectricDepartment()
        {
            Console.WriteLine("Your are in " + departmentName + " department");

        }
    }

    class ObjectCreationClass
    {
        void Main()
        {
            WaterDepartment waterDepartment = new WaterDepartment();
            waterDepartment.getGovernmentDetails();

            ElectricDepartment electricDepartment = new ElectricDepartment();
            electricDepartment.getGovernmentDetails();
        }
    }
}
