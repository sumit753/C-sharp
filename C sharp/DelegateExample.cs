using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{

    //We can sort simple type using sort ,reverse methods but with complex type we can't use these methods
    //So to sort complex type like classes.we need to implement IComparable interface. 
    public class EmployeeClass : IComparable<EmployeeClass>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int expierence { get; set; }

        //for delegateDemo
        public static void promoteEmployee(List<EmployeeClass> Employees,isPromotable promoDelegate)
        {
            foreach (EmployeeClass emp in Employees)
            {
                if (promoDelegate(emp))
                {
                    Console.WriteLine(emp.name);
                } 
            }
        }

        //for dictionary demo
        public override string ToString()
        {
            Console.WriteLine("Id: " + this.id + " Name :" + this.name + " Salary :" + this.salary);
            return null;
        }

        //impelementing method (For complex type comparison Demo)
       public int CompareTo(EmployeeClass other)
        {
            if (this.salary > other.salary)
                return 1;
            else if (this.salary < other.salary)
                return -1;
            else
                return 0;
        }
    }
}
