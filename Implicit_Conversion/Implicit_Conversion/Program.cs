using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {

            long myVar = 1000;
            float myVar2 = myVar;

           // float myfolatVar = 12.5f;
           // int myInt2Var = myfolatVar;     //Wrong, it needs an explicit conversion


           // Console.WriteLine($"{myVar2}");

            char myVar3 = 'G';
            int myIntvar = myVar3;

            Console.WriteLine($"{myIntvar}");
            Console.ReadKey();


            // byte  -->   short, ushort, int, uint, long, ulong, float, double, decimal
            //sbyte  -->   short, int, long, float, double, decimal
            //short  -->   int, long, float, double, decimal
            //ushort -->   int, uint, long, ulong, float, double, decimal
            //int    -->   long, float, double, decimal
            //uint   -->   long, ulong, float, double, decimal
            //long   -->   float, double, decimal
            //ulong  -->   float, double, decimal
            //float  -->   double
            //char   -->   ushort, int, uint, long, ulong, float, double, decimal


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
