using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class PropertyExample
     {
         private int id;
         private string name;
 
         //auto implemented properties. 
         //the compiler creates a private,anonymous field that can be accessed through the property
 
         public string City { set; get; }
 
         public string Email { set; get; }
 
 
         public int Id
         {
             set
             {
                 if (value< 0)
                 {
                     throw new Exception("Id can't be negative");
                 }
                 this.id = value;
             }
 
             get
             {
                 return this.id;
             }
         }
 
 
         public string Name
         {
            set
             {
                 if (string.IsNullOrEmpty(value))
                 {
                     throw new Exception("Name can't be null or empty");
                 }
                 this.name = value;
             }
 
             get
             {
                 return this.name;
             }
         }
     }
}
