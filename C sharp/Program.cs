using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public delegate bool isPromotable(EmployeeClass emp);

    
    class Program
    {   //For Delegate Example.
        public static bool promoteMethod(EmployeeClass emp)
        {
            if (emp.expierence > 5)
            {
                return true;
            }
            else
                return false;

        }

        static void Main(string[] args)
        {
            // ####### MethodHiding Code###########
            Console.WriteLine("############ MethodHiding ###");
            //this will call parent class method implementation
            ParentClass pObj = new ParentClass();
            pObj.printFullName();

            //this will call parent class method implementation
            ParentClass parentRef = new ChildClass();
            parentRef.printFullName();

            //this will call child class method implementation

            ChildClass cObj = new ChildClass();
            cObj.printFullName();

            //######## Method Code Ends##########


            //######## Runtime Polymorphism..
            // it allows to invoke derived class methods through base class reference during runtime.
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("############ Runtime PolyMorphism ###");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // creating the array of Employee reference
            Employee[] empRef = new Employee[4];

            empRef[0] = new Employee();
            empRef[1] = new PartTimeEmployee();
            empRef[2] = new FullTimeEmployee();
            empRef[3] = new TemporaryEmployee();

            foreach (Employee e in empRef)
            {
                e.display();
            }

            Console.WriteLine(" ");

            // properties Example
            Console.WriteLine("############ Properties Example ###");
            Console.WriteLine(" ");
            PropertyExample Student = new PropertyExample();
            Student.Id = 10;
            Student.Name = "Sumit";
            Student.Email = "Sumit753@gmail.com";
            Student.City = "Indore";

            Console.WriteLine("Student Details");

            Console.WriteLine("ID- " + Student.Id + " Name : " + Student.Name + " Email: " + Student.Email + " City : " + Student.City);
            Console.WriteLine(" ");

            Console.WriteLine("===== Explict InterfaceExample==== ");
            Console.WriteLine(" ");

            InterfaceExample iObj = new InterfaceExample();

            // defult implementation will be called i.e. I1's method implementation
            iObj.InterfaceMethod();

            //Interface I2's  method will be called
            ((I2)iObj).InterfaceMethod();

            // Or we can do following 

            I2 i2_ref = new InterfaceExample();
            i2_ref.InterfaceMethod();


            //Interface I3's  method will be called
            ((I3)iObj).InterfaceMethod();

            // OR
            I3 i3_ref = new InterfaceExample();
            i3_ref.InterfaceMethod();

            Console.WriteLine(" ");

            Console.WriteLine("===== Multiple Inheritance Through Interfaces ==== ");
            Console.WriteLine(" ");

            AB abObj = new AB();
            abObj.methodA();
            abObj.methodB();


            Console.WriteLine(" ");

            Console.WriteLine("===== Delegate Example ==== ");
            Console.WriteLine(" ");

            Console.WriteLine("Promoted Employeees ");

            List<EmployeeClass> empList = new List<EmployeeClass>();

            empList.Add(new EmployeeClass() { id = 1, name = "Laxman", salary = 5000, expierence = 6 });
            empList.Add(new EmployeeClass() { id = 2, name = "Ramesh", salary = 6000, expierence = 7 });
            empList.Add(new EmployeeClass() { id = 3, name = "Rahil", salary = 7000, expierence = 3 });

            //initializing delegate
            isPromotable isPromotableDelegate = new isPromotable(promoteMethod);

            EmployeeClass.promoteEmployee(empList,isPromotableDelegate);

            Console.ReadKey();
        }
    }
}
