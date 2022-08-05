using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPSConcepts
{
    class Organization // Class
    {
        readonly string organizationName = "Kalpita Technologies";
        String empoyeeName;
        int employeeID;


        public void getOrganizationProfile()
        {
           Console.WriteLine("Organizaion name is "+organizationName);
        }

        public void getEmployeeProfile(int empID,String empName)
        {
            this.employeeID = empID;
            this.empoyeeName=empName;

            Console.WriteLine("-------------Employe Profile-------------");
            Console.WriteLine("Employe ID is " + employeeID + " , Employe Name is " + empoyeeName);
        }
    }
     interface IHr  // Interface
    {
        void ApplyForLeave();

    }

    class Employee : Organization,IHr // Implementing Class and Interface
    {

        public void ApplyForLeave()
        {
            Console.WriteLine("For Leave apply here!");
        }

        static void Main()
        {
            Employee employee = new Employee();
            employee.ApplyForLeave();
            employee.getOrganizationProfile();
            employee.getEmployeeProfile(123, "Anand");

        }
    }


}
