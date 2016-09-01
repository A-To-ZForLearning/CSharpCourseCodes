using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Precedences
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %  ++ -- = += -= *= /= %= ++ --

            int myVar1 = 6, myVar2 = 7, myVar3 = 3, temp, temp2;

           // temp = myVar1 + myVar2;

            //temp = myVar1 + myVar2 * myVar3;
            //temp = myVar1 * myVar2 / myVar3;
             temp = (myVar1 + ++myVar2) * --myVar3;

            myVar1 = 6;
            myVar2 = 7;
            myVar3 = 3;
            
            temp2 = (myVar1 + myVar2++) * myVar3--;

            Console.WriteLine("{0}\n\n{1}",temp,temp2);
            Console.ReadKey();
   

            /*
Highest Operators   ++, -- (used as prefixes); +, - (unary)
                    *, /, %
                    +, -
                    =, *=, /=, %=, +=, -=
Lowest  Operators   ++, -- (used as postfixes)
*/


           /*
                        Q1 / try to get the result 15 of these variables

                         myVar1 = 1
                         myVar2 = 3
                         myVar3 = 4
                         myVar4 = 2
                         myVar5 = 11


                         ++myVar1 + myVar2 * --myVar3 / ++myVar4 + --myVar5;

                */





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
