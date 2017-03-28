using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    
    class Program
    {
        #region Casting examples

        //#region Example of "as" keyword in action
        //private static void ArrayObjects()
        //{
        //    object[] myObjArr = new object[4];
        //    myObjArr[0] = "Last thing";
        //    myObjArr[1] = new Managers();
        //    myObjArr[2] = false;
        //    myObjArr[3] = new Accountants();

        //    foreach (object testObj in myObjArr)
        //    {
        //        Accountants myNewAccObj = testObj as Accountants;
        //        if (myNewAccObj == null)
        //            Console.WriteLine("Object is not an Accountants");
        //        else
        //        {
        //            myNewAccObj.PrintAcountantName();
        //        }
        //    }
        //}
        //#endregion
        static void ObjectsCastingMethod()
        {
            // A Manager "is-a" System.Object. therefore, we can
            // store a Manager reference in an object variable just fine.
            object jasim = new Managers("jasim kareem", 50, 30, 400, "141-14-1278", 5);
           
            // A Manager "is-an" Employee too.
            Employee hussein = new Managers("Hussein Abed", 27, 22, 20000, "151-14-1321", 1);
            GivePromotion(hussein);
            hussein.DisplayEmpInfo();

            // A Finance "is-a" HumanRes.
            HumanRes karwan = new Finance("karwan", 34, 3002, 100000, "123-22-1799", 90);
            GivePromotion(karwan);
            karwan.DisplayEmpInfo();

            
            
        }
        #endregion

        #region Example of "is" keyword in action
        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);

            if (emp is HumanRes)
            {
                Console.WriteLine("Human Resources {0} had {1} employee(s)!", emp.Name,
                  ((HumanRes)emp).EmpNumber);
                Console.WriteLine();
            }
            if (emp is Managers)
            {
                Console.WriteLine("Manager {0} had {1} employee(s)!...", emp.Name,
                  ((Managers)emp).EmployeeNumber);
                Console.WriteLine();
            }
           
        }
        #endregion
        static void Main(string[] args)
        {
            ObjectsCastingMethod();

            //A better bonus system!
           //Managers ahmed = new Managers("Ahmed", 25, 42, 1054, "743-21-2282", 945);
           // ahmed.GiveBonus(150);
           // ahmed.DisplayEmpInfo();
           // Console.WriteLine();

           // HumanRes ali = new HumanRes("Ali", 43, 93, 1400, "422-37-3282", 301);
           // ali.GiveBonus(100);
           // ali.DisplayEmpInfo();
           // Console.WriteLine();

        

            // object kasimy = new Managers();
            //Accountants moh = (Accountants)kasimy;


            //object kasim = new Managers();
            //Accountants myAccObje;
            //try
            //{
            //    myAccObje = (Accountants)kasim;
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //ArrayObjects();

            Console.ReadKey();

            /*  

for more information visit
         http://www.youtube.com/c/AToZForLearning 

Visit our channel page on facebook
         https://www.facebook.com/AToZForLearning/

If you have any question in English or Arabic welcome to our facebook group 
         https://www.facebook.com/groups/AToZForLearningProgramming/  


         */

        }

    }
}
