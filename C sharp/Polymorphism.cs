using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    
  //Polymorphism
    public class Employee
    {
        public String firstName = "FirstName";
        public String lastName = "LastName";

        // virtual keyword is used to make the method Overridable by derived classes
        public virtual void display()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void display()
        {
            Console.WriteLine(firstName + " " + lastName + "PartTime Employee");
        }
    }
    class FullTimeEmployee : Employee
    {
        public override void display()
        {
            Console.WriteLine(firstName + " " + lastName + "FullTime Employee");
        }

    }
    class TemporaryEmployee : Employee
    {
        public override void display()
        {
            Console.WriteLine(firstName + " " + lastName + "Temporary Employee");
        }
    }
}

