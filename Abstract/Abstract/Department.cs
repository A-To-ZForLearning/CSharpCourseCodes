using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Department
    {
        public string departName { get; set; }
        public int departEmpNumber { get; set; }
        public int departRoomsNumb { get; set; } = 6;
        public Managers myManag{ get; set; }

        public Department()
        {
            //departRoomsNumb = 5;
            myManag = new Managers();
            
        }
        public Department(int number, Managers myMana)
        {
            departRoomsNumb = number;
            myManag = myMana;
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
}
