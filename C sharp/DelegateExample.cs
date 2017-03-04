using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{   
    public class EmployeeClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int expierence { get; set; }

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
    }
}
