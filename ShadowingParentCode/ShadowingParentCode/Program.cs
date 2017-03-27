using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingParentCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nazar Al-Wattar";
            int empID = 145;
            HumanRes myHumObj = new HumanRes(empID, name);
            myHumObj.PrintHuName();
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
