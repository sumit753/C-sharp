using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //Step 1 Create a method whose signature matches with the signature of perdicate<Person> delegate.
        public static bool criteriaMethod(Person person)
        {
            return person.Age > 20;
        }
    }



}
