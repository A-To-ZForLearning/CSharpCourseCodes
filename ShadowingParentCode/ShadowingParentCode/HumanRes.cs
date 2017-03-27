using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingParentCode
{
    class HumanRes : Employees
    {
        public int humResID;
        public string humResNam;
        
        public HumanRes(int empID, string name)
        {
            humResID = empID;
            humResNam = name;
        }
        public void PrintHuName()
        {
            Console.WriteLine("Print ID {0}\nPrint Name {1} ", humResID, humResNam);
        }
    }
}
