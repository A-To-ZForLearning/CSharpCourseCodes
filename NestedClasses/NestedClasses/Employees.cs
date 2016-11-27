using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    class Employees
    {
        public string fName = "Ahmed Kasim";
        public string Address = "Jefferson Rd";
        public void PrintValues() { Console.WriteLine($"Employee Name is  {fName} \n Living at {Address}"); }

        public class Departments
        {
            public string departmentName = "Administration";
            public void PrintDepartmentName() { Console.WriteLine($"Working at  {departmentName}"); }

        }
    }
}
