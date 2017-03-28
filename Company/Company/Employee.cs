using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    abstract class Employee
    {
        // Data Fields.
        private string empName;
        private int empID;
        private float empPay;
        private int empAge;
        private string empSSN = "";

        #region Constructores
       //Default
        public Employee() { }

        //Paramertized Constructors
        public Employee(string name, int id, float pay)
        { }
             
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            empSSN = ssn;
        }
        #endregion

        #region Properties 
        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name length exceeds 15 characters");
                else
                    empName = value;
            }
        }
                
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return empPay; }
            set { empPay = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        #endregion
	
		 public virtual void DisplayEmpInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }
		
		 public virtual void GiveBonus(float amount)
        { Pay += amount; }
    }
}
