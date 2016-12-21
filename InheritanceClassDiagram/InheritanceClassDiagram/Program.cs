using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars myCarsObj = new Cars();
            Toyota myToyotaObj = new Toyota();
            Nissan myNissanObj =  new Nissan();
            Ford myFordObj = new Ford();

            myCarsObj.PrintMake();
            myFordObj.PrintMake();
            myNissanObj.PrintMake();
            myToyotaObj.PrintMake();

            Console.ReadKey();

            //Challenge3
            //Craete a base class called Person
            //Create a child class called Employee
            //Create A child class that inheritaned from Employee called Managers
            //Create A child class that inheritaned from Employee called HR
            //Create A child class that inheritaned from Employee called Financial


        }
    }
}
