using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Employees
    {
        public string name;
        public string department;
        public abstract void PrintName();
        public abstract void PrintDepart();
    }
}
