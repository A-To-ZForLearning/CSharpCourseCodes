using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusionPolymorphsim
{
   

    
    class Employees
    {
        public Employees()
        {
            Console.WriteLine("\nConstractor\n");
        }
             //Destructors cannot be defined in structs.They are only used with classes.
            //A class can only have one destructor.
           //Destructors cannot be inherited or overloaded.
          //Destructors cannot be called. They are invoked automatically.
         //A destructor does not take modifiers or have parameters.
 ~ Employees()
        {
            Console.WriteLine("\nDestractor\n");
        }
        public virtual void  PrintName()
        {
            Console.WriteLine("\nI'm print from class Employees\n");
        }
       
        
    }
}
