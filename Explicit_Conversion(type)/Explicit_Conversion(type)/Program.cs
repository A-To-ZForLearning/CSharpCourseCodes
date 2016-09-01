using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion_type_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type1 = (Type1)Type2                  //Casting
            
            byte mySbyte;                           //0 - 255
            int myInt = 350;                        //‭000101011110‬
            // mySbyte = myInt;                    // 000011111111‬                
            mySbyte = (byte)myInt;                 // 000001011110
                                        
            Console.WriteLine($"My variable Int = {myInt}" + "\n");     
            Console.WriteLine($"My byt variable  = {mySbyte}");         
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
