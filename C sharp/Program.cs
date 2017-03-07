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
        //we can get rid of this method by using lambda expression
        //public static bool promoteMethod(EmployeeClass emp)
        //{
        //    if (emp.expierence > 5)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;

        //}

            

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

            //no need to intialize the delegate now
            //isPromotable isPromotableDelegate = new isPromotable(promoteMethod);

            //using lambda expression
            // "empLambdaExpName" will be automaticaly associate itself with "EmployeeClass" which is passed in Declaration of Delegate.
             EmployeeClass.promoteEmployee(empList,empLambdaExpName => empLambdaExpName.expierence >2);

            Console.WriteLine(" ");

            Console.WriteLine("===== Anonymous Method Demo ==== ");
            Console.WriteLine(" ");

            List<Person> personList = new List<Person>();

            personList.Add(new Person() { Name = "Sumit" ,Age=24 });
            personList.Add(new Person() { Name = "Amit", Age = 25 });
            personList.Add(new Person() { Name = "Aman", Age = 18 });
            personList.Add(new Person() { Name = "Chinky", Age = 20 });
            personList.Add(new Person() { Name = "Pinky", Age = 19 });

            //Step 2 Anonymous method example -create instance of Predicate<Person> delegate and
            // pass the name of method created in step 1 into Perdicate's constructor.

            Predicate<Person> personDelgate = new Predicate<Person>(Person.criteriaMethod);

            //Step 3 Anonymous method example 
            //Now pass the delegate instance as an argument for Find method.
            
            Person p=personList.Find(person => personDelgate(person));
            Console.WriteLine("====Without Using Anonymous Method===");
            Console.WriteLine(" ");
            Console.WriteLine(p.Name);
            //we did all these three steps because Find() method accepts Predicate delegate as an agrument.
            // find method return only first occurance of matched condition in the entire list. If we need all 
            // occurences than we can use FindAll() method.

            Console.WriteLine("");
            Console.WriteLine("====Using Anonymous Method===");
            Console.WriteLine("");
            //Anonymous method is passed as and argument in Find method
            // This anonymous method replace the need for step 1,2 &3

            Person person1 = personList.Find(
                
                    //anonymous method
                    delegate(Person x)
                    {
                        return x.Age < 20;

                    }
            
                
                );

            Console.WriteLine(person1.Name);

            Console.WriteLine("");
            // Console.WriteLine("====Using Atrribute Demo===");
            //Console.WriteLine("");

            //AttributeExample objAttribute = new AttributeExample();
            //its showing warning when we are using add method.
            //objAttribute.Add(10, 20);

            Console.WriteLine("");
             Console.WriteLine("==== Generics Demo===");
            Console.WriteLine("");

            GenericsDemo genDemo = new GenericsDemo();
            bool result = genDemo.compareVariables<int>(10, 20);
            Console.WriteLine("are 10 & 20 equal?? :"+ result);

            bool result2 = genDemo.compareVariables<string>("Sumit", "Karma");

            Console.WriteLine("are Sumit & karma equal ?? :" + result2);

            Console.ReadKey();
        }
    }
}
