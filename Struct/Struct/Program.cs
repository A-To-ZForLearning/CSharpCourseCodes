using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strucut
{
    class Program
    {
        enum toyota : byte
        {
            RAV4 = 1,
            Camery = 2,
            Tundra = 3,
            Highland = 4
        }
        struct carType
        {

            public toyota modelName;
            public double modelYear;
        }

        static void Main(string[] args)
        {
            carType myCarType;
            int carType = -1;
            double modelYear;
            Console.WriteLine("1) RAV4\n2) Camery\n3) Tundra\n4) Highland ");
            do
            {
                Console.WriteLine("Enter Your Car Type:");
                carType = Convert.ToInt32(Console.ReadLine());
            }
            while ((carType < 1) || (carType > 4));

            Console.WriteLine("Input a modelYear :");
            modelYear = Convert.ToDouble(Console.ReadLine());
            myCarType.modelName = (toyota)carType;
            myCarType.modelYear = modelYear;
            Console.WriteLine($"My Car Type is {myCarType.modelName} " +
            $"and the model Year is {myCarType.modelYear}");
            Console.ReadKey();


            //Q21/ Define a struct that contains the directions by the orientation
            //as a enum and the distance to reach a destination
            // and print the direction and that distance


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

