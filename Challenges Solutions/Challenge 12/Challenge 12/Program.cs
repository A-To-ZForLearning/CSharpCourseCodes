using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_12
{
    class Program
    {
        static void Main(string[] args)
        {

            int myWeight = 120, desiredWeight = 83, ix = 0;
            int losePerExercise = 1;
            while (myWeight > desiredWeight)
            {

                myWeight = myWeight - losePerExercise;
                ix++;
            }
            Console.WriteLine(ix);
            Console.ReadKey();

        }
    }
}
