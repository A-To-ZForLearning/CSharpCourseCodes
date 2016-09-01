using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp1, temp2, myVar1 = 5, temp3;
            temp1 = myVar1++;

            myVar1 = 5;
            temp2 = ++myVar1;
            Console.WriteLine("The value of myVar++ is {0},"+
                " While the result of ++myVar is {1}", temp1, temp2);

                myVar1 = 7;
            int myVar2 = 2;

            temp3 = myVar1-- / ++myVar2;
            Console.WriteLine("The result of this expression (myVar1-- / ++myVar2) is {0}", temp3);

            //I still looking for the answer Why?
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
