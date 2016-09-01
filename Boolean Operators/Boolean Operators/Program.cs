using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //Boolean Comparison   ==, !=, <, >, <=, >=
            // Boolean Conditions  &&, ||

            bool myResult;
            int myVar1 = 5, myVar2 = 8;                                               //  &  Table Truth
            myResult = myVar1 != 8;                                                   //  F  F --> F
                                                                                      //  T  F --> F 
            myResult = (myVar1 <= 5) && (myVar2 > 8);                                //  F  T --> F 
                                                                                      //  T  T --> T
            Console.WriteLine("MyResult is ={0}", myResult);
            Console.ReadKey();

            /*
  Q1 /Define myVar1 = 9, myVAr2=11 and  Print the result of this conditions
  1- (myVar1 <10) && (myVar2<=11)
  2- (myVar1 <10) || (myVar2<=11)
  and Why?
     */




            /*
             
       Highest       ++, −− (used as prefi xes); (), +, – (unary), !, ˜
                     *, /, %
                     +, –
                     <<, >>
                     <, >, <=, >=
                     ==, !=
                     &
                     ^
                     |
                     &&
                     ||
                     =, *=, /=, %=, +=, −=, <<=, >>=, &=, ^=, |=
       Lowest        ++, –– (used as suffi xes)
             
            
            */






 /*  
  
 for more information visit
          http://www.youtube.com/c/AToZForLearning 
		  
Visit our channel page on facebook
          https://www.facebook.com/AToZForLearning/

If you have any question in English or Arabic welcome to our facebook group 
          https://www.facebook.com/groups/AToZForLearningProgramming/  
			  
		  
		  */}
    }
}
