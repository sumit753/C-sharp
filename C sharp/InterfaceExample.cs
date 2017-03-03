using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }

    interface I3
    {
        void InterfaceMethod();
    }

    class InterfaceExample : I1, I2, I3
    {
        // all three  Interface members will be implemented throught single implementation as name of methods are same in all Interfaces.
        public void InterfaceMethod()
        {
            Console.WriteLine("Defualt I1 InterFaceMethod");
        }

        // TO Explictly implement method implementation we can do following

        void I2.InterfaceMethod()
        {
            Console.WriteLine("Explict Interface2 Method implementation");
        }

        void I3.InterfaceMethod()
        {
            Console.WriteLine("Explict Interface3 Method implementation");
        }

    }
}
