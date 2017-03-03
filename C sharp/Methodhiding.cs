using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ParentClass
    {
        string firstName, lastName;

        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

    }

    class ChildClass : ParentClass
    {
        // "new" keyword is used to hide parent class method
        public new void printFullName()
        {
            Console.WriteLine("Child class Method implementation");
        }
    }


    class MethodHiding
    {
        void Main()
        {   //this will call parent class method implementation
            ParentClass pObj = new ParentClass();
            pObj.printFullName();

            //this will call parent class method implementation
            ParentClass parentRef = new ChildClass();

            //this will call child class method implementation

            ChildClass cObj = new ChildClass();
            cObj.printFullName();


        }
    }
