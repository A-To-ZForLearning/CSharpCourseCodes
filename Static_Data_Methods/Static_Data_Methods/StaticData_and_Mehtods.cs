using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Data_Methods
{
    class StaticData_and_Mehtods
    {
        // Static Data at Instance-level.
        public double currBalance;

        // A static point of data.
        public static double currInterestRate;
        
        //Parameterized Constructor
        public StaticData_and_Mehtods(double balance)
        {
            currBalance = balance;
            
        }

        static StaticData_and_Mehtods()
        {
            currInterestRate = 0.5;
        }
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }

        public static double GetValue()
        { return currInterestRate; }

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
