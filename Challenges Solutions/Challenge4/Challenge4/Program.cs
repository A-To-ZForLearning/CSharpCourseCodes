using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 7, myVar2 = 3, temp;

            temp = myVar1 + myVar2;
            Console.WriteLine("myVar1 + myVar2 = " + "{0}", temp);

            temp = myVar1 - myVar2;
            Console.WriteLine("myVar1 - myVar2 = " + "{0}", temp);

            temp = myVar1 * myVar2;
            Console.WriteLine("myVar1 * myVar2 = " + "{0}", temp);

            temp = myVar1 / myVar2;
            Console.WriteLine("myVar1 / myVar2 = " + "{0}", temp);

            temp = myVar1 % myVar2;
            Console.WriteLine("myVar1 % myVar2 = " + "{0}", temp + "\n");


            string myStr1 = "I am", myStr2 = " smart";
            Console.WriteLine("{0}", myStr1 + myStr2);


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
