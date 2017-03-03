using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    interface IA
    {
        void methodA();
    }

    interface IB
    {
        void methodB();
    }

    class A : IA
    {
        public void methodA()
        {
            Console.WriteLine("Method A implementation");
        }
    }

    class B : IB
    {
        public void methodB()
        {
            Console.WriteLine("Method B Implementation");
        }
    }

    //multiple inheritance through interfaces
    class AB : IA, IB
    {
        A aObj = new A();
        B bObj = new B();

        public void methodA()
        {
            aObj.methodA();
        }

        public void methodB()
        {
            bObj.methodB();
        }
    }
}
