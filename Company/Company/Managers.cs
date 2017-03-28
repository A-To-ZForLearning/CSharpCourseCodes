using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Managers : Employee 
    {
        #region constructors 
        public Managers()
        {

        }

        public Managers(string fullName, int age, int empID,
                       float currPay, string ssn, int numbOfOpts)
          : base(fullName, age, empID, currPay, ssn)
        {
            // This property is defined by the Managers class.
            EmployeeNumber = numbOfOpts;
        }
        #endregion

        public int EmployeeNumber { get; set; }

       public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            EmployeeNumber += r.Next(500);
        }
        public override void DisplayEmpInfo()
        {
            base.DisplayEmpInfo();
            Console.WriteLine("Number of Employees: {0}", EmployeeNumber);
        }
    }
}
