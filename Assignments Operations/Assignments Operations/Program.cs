using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //=, +=, -=, *=, /=, %=, 

            int myVar1 = 7, myVar2 = 3;

            //myVar2 = myVar1;

            // myVar2 += myVar1;    //myVar1 = myVar1 + myVar2

         //   myVar1 -= myVar2;      //myVar1 = myVar1 - myVar2

            myVar1 %= myVar2;     //myVar1 = myVar1 % myVar2

            Console.WriteLine("The Result is = {0} The values of Var2 =  {1}", myVar1,myVar2);
            Console.ReadKey();
            /*

            Q1/ What's the result of this expression
               int  temp, myVar1 = 7, myVar2 = 2;

              myVar1 /= ++myVar2; 
                     and Why;
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
