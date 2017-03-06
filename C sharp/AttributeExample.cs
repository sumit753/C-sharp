using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class AttributeExample
    {   //Step 2) Now we have much more flexible methods then following method we don't need it anymore.
        //to prevent user from using this method we can make use of attribute.
        //with the help of attribute we can show warning or error message to user when he tries to use this method.

        //if we want show error when user uses Add method then pass "true" as second parameter in Obsolete constructor
        //[Obsolete("Use Add(List<int> Numbers) method.",true)]
        //this will show warning.When user uses Add method.

        [Obsolete("Use Add(List<int> Numbers) method.")]
        public int Add(int a, int b)
        {
            return a + b;

        }

        

        // Step 1)--what if user wants to add twenty numbers??.

        //to make it possible ,We use much flexible method 

        public int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach (int number in Numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
