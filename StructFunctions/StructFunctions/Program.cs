using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructFunctions
{
    class Program
    {
        struct FullNmae
        {
            public string myFirstName, myLastName;
            public string printName()=> myFirstName + " " + myLastName;
        }
        static void Main(string[] args)
        {
            FullNmae myFullname;
            myFullname.myFirstName = "Nazar";
            myFullname.myLastName = "Al-Wattar";
            //Console.Write($"{myFullname.myFirstName}{myFullname.myLastName}");
            Console.Write(myFullname.printName());
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
