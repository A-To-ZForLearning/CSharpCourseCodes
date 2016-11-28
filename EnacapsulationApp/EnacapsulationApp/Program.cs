using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnacapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nazar Al-Wattar";
            int age = 32;
            Person myObj = new Person();
            myObj.SetName(name);
            myObj.SetAge(age);

            Console.WriteLine("Name is " + myObj.GetName());
            Console.WriteLine("Age is " + myObj.GetAge());
            Console.ReadKey();
            //Challenge 1
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
