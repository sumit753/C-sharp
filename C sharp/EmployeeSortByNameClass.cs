using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class EmployeeSortByNameClass : IComparer<EmployeeClass>
    {
        // we have to make various classes for different criteria by which we want to sort the EmployeeClass object.
        //and implement IComparer interface in those classes.
        public int Compare(EmployeeClass x, EmployeeClass y)
        {
            return x.name.CompareTo(y.name);
        }
    }
}
