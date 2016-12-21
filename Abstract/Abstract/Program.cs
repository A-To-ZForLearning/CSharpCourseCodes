using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Managers myManaObj= new Managers();
            myManaObj.nameManager = "Ahmed";
            Department myDep = new Department();

            myDep.departEmpNumber = 12;
            myDep.departName = "Managers";
            myDep.myManag = myManaObj;

            Console.WriteLine($"{myDep.departEmpNumber}\n{myDep.departName}");
            Console.WriteLine($"{myDep.departRoomsNumb}\n { myDep.myManag.nameManager}");
            Console.ReadKey();

           
        }
    }
}
