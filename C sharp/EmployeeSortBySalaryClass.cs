using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class EmployeeSortBySalaryClass : IComparer<EmployeeClass>
    {
        public int Compare(EmployeeClass x, EmployeeClass y)
        {
            return x.salary.CompareTo(y.salary);
        }
    }
}
