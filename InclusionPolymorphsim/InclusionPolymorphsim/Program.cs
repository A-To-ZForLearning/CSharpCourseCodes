using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusionPolymorphsim
{
    class Program
    {
        class First
        {
            ~First()
            {
                Console.WriteLine("First's destructor is called.");
            }
        }

        class Second : First
        {
            ~Second()
            {
                System.Diagnostics.Trace.WriteLine("Second's destructor is called.");
            }
        }

        class Third : Second
        {
            ~Third()
            {
                System.Diagnostics.Trace.WriteLine("Third's destructor is called.");
            }
        }
        static void Main(string[] args)
        {
            Employees myEmp = new Employees();
            myEmp.PrintName();
            myEmp = new Managers();
            myEmp.PrintName();
            myEmp = new HuRes();
            myEmp.PrintName();
            Third t = new Third();
            Console.ReadKey();
        }
    }
}
