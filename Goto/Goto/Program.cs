using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Goto
{
    class Program
    {  static int MyFunction()
        {
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) // Until condition Execute.
                {
                       if (j == 5)
                        {
                            goto MyLabel;
                        }
                    
                    counter++;
                }
            MyLabel:
                continue;
            }
            return counter;
        }

        static void Main()
        {
            //WriteLine(MyFunction());

            int counter = 0;
            // myLable2:

            if (counter < 10)
            {
                counter++;
                //goto myLable2;
            }
            else
            {
                WriteLine("Done");

                WriteLine(counter);
            }


            ReadKey();
        }

      
    }



    /*  

    for more information visit
             http://www.youtube.com/c/AToZForLearning 

   Visit our channel page on facebook
             https://www.facebook.com/AToZForLearning/

   If you have any question in English or Arabic welcome to our facebook group 
             https://www.facebook.com/groups/AToZForLearningProgramming/  


             */



}
