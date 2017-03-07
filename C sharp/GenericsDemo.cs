using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class GenericsDemo
    {   //we want to make this method independent of datatype 
        //one way is to use object parameters.Since every type indirectly or directly inherits from System.Object type
        //but problem with this approach is that it degrades performance due boxing and unboxing.
        //also the method is not typesafe as it is possible to pass integer for the first parameter and string for second parameter.
        // it make no sense in comparing integer with string.
           
        //public static bool isEqual(object a, object b)
        //{
        //    return a.Equals(b);
        //}

        //another approach is to make method generic
        public bool compareVariables<S>(S a,S b)
        {
            return a.Equals(b);
        }
    }
}
