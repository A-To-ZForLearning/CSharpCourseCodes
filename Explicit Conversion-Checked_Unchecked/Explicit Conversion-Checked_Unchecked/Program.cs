using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion_Checked_Unchecked
{
    class Program
    {
        static void Main(string[] args)
        {

            //Type1 = (Type1)Type2                  //Casting

            byte mySbyte;                           //0 - 255
            int myInt = 350;                        //‭000101011110‬
                                                   // 000011111111‬                
            mySbyte = (byte)myInt;                 // 000001011110

            Console.WriteLine($"My variable Int = {myInt}" + "\n");
            Console.WriteLine($"My byt variable  = {mySbyte}");
            Console.ReadKey();
            

            //Q17/ Define a decimal variable and then convert it to an Integre variable using 
            //either Implicit or Explicit conversion operations and use checked keyword to through 
            // an exception of overflow type
            


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
