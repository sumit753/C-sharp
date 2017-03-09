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

            empList.Add(new EmployeeClass() { id = 1, name = "Laxman", salary = 15000, expierence = 6 });
            empList.Add(new EmployeeClass() { id = 2, name = "Ramesh", salary = 68400, expierence = 7 });
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

            Console.WriteLine("");
            Console.WriteLine("====Dictionary Demo===");
            Console.WriteLine("");

            Dictionary<int, EmployeeClass> employeeDictionary = new Dictionary<int, EmployeeClass>();

            EmployeeClass emp1 = new EmployeeClass() { id = 1,name="Sumit",salary=10000 };
            EmployeeClass empl2 = new EmployeeClass() { id = 2, name = "Amit", salary = 5000 };
            EmployeeClass emp3 = new EmployeeClass() { id = 3, name = "Rahul", salary = 4850 };

            employeeDictionary.Add(emp1.id,emp1);
            employeeDictionary.Add(empl2.id, empl2);
            employeeDictionary.Add(emp3.id, emp3);

            //accessing the dictionary using key 
            EmployeeClass emp = employeeDictionary[1];

            Console.WriteLine(emp);

            Console.WriteLine();
            //Understanding dictionary methods
            EmployeeClass emp4 = new EmployeeClass() { id = 4, name = "Vaibhav", salary = 15000 };
            EmployeeClass emp5 = new EmployeeClass() { id = 5, name = "Ranu", salary = 5100 };
            EmployeeClass emp6 = new EmployeeClass() { id = 6, name = "Rakesh", salary = 14850 };

            EmployeeClass[] empArray = new EmployeeClass[3];
            empArray[0] = emp4;
            empArray[1] = emp5;
            empArray[2] = emp6;

            //converting array into Dictionary

             Dictionary<int,EmployeeClass> empDict = empArray.ToDictionary(y => y.id,y=>y);

            employeeDictionary.AddRange(empDict);
            Console.WriteLine("---------After Merging two dictionary-----------------------");
            foreach (KeyValuePair<int,EmployeeClass> keyvaluepair in employeeDictionary)
            {
                EmployeeClass eRef = keyvaluepair.Value;
                Console.WriteLine(eRef);
                Console.WriteLine("---------------------------------------------");
            }

            Console.WriteLine("Dictionary Count Function");

            int i = employeeDictionary.Count(ep => ep.Value.salary > 14000);
            Console.WriteLine(i);


            Console.WriteLine("");
            Console.WriteLine("====Sorting Complex types Demo===");
            Console.WriteLine("");


            //using the EmployeeClass list created at line no 128
            Console.WriteLine("-------------------------");
            Console.WriteLine("EmployeeList Before Sorting");
            Console.WriteLine("-------------------------");
            foreach (EmployeeClass empl in empList)
            {
                Console.WriteLine("Name : {0} , Salary{1}", empl.name, empl.salary);

            }
            empList.Sort();
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("EmployeeList after Sorting");
            Console.WriteLine("-------------------------");
            foreach (EmployeeClass empl in empList)
            {
                Console.WriteLine("Name : {0} , Salary : {1}", empl.name, empl.salary);

            }

            //we can also sort empList by name,salary,id By creating another class and implementing 
            // IComparer interface. & then creating the object of that class and passing it in Sort method
            // as argument.
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("EmployeeList Sorting by name");
            Console.WriteLine("-------------------------");
            Console.WriteLine( " ");
            EmployeeSortByNameClass EmpByName = new EmployeeSortByNameClass();
            empList.Sort(EmpByName);
            foreach (EmployeeClass empl in empList)
            {
                Console.WriteLine("Name : {0} , Salary : {1}", empl.name, empl.salary);

            }
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("EmployeeList Sorting by salary");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" ");
            EmployeeSortBySalaryClass EmpBySalary = new EmployeeSortBySalaryClass();
            empList.Sort(EmpBySalary);
            foreach (EmployeeClass empl in empList)
            {
                Console.WriteLine("Name : {0} , Salary : {1}", empl.name, empl.salary);

            }

            // Console.ReadKey();
        }
    }
}
