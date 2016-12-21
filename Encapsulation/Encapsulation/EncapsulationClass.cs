using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class EncapsulationClass
    {
        private string fname = "Ahmed";
        private string mname = "Ali";
         string lname = "AlObaidy";
         int age = 25;
        public void PrintFullName() { Console.WriteLine($"{fname}  {mname} {lname}"); }
        public void PrintAge() { Console.Write($"My Age is  {age}"); }

        public void set(string fname, string mname)
        {
            this.fname = fname;
            this.mname = mname;

        }
        public string get1()
        {
            return fname;
        }
        public string get2()
        {
            return mname;
        }
    }
}
