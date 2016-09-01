using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_11
{
    class Program
    {
        static void Main(string[] args)
        {

            int salary = 1000, increment = 20, salarydesired = 2000;
            int i = 0;
            do
            {
                salary += increment;
                i++;

            } while (salary < salarydesired);

            float years = i / 12;
            Console.WriteLine("{0}\n{1}", i, years);
            Console.ReadKey();

        }
    }
}
