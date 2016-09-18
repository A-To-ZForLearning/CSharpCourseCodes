using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum humanSex :sbyte
            {
            male =  1,
            female = 2

           }
        static void Main(string[] args)
        {
            sbyte humanSbyte;
           
            humanSex myhumanSex = humanSex.male;
            Console.WriteLine($"Human Sex =  {myhumanSex}" + "\n" );
            humanSbyte = (sbyte)myhumanSex;
            Console.WriteLine($"Human Gender index in  = {humanSbyte}" + "\n");
            string humanGender;
            humanGender = Convert.ToString(myhumanSex);
            Console.WriteLine($"Human associated with this index = {humanGender}" + "\n");
            Console.ReadKey();




            //Q20/ Define an Enum variable for orientation and print the contents usign loop
            //and start from index 2




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
