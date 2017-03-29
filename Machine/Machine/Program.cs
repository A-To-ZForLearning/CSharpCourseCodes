using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("=> Creating a Machine and stepping on it!");
            Machine myMachine = new Machine("Zippy", 20);
            myMachine.CrankTunes(true);

            // Speed up past the Machine's max speed to
            // trigger the exception.
            try
            {
                for (int i = 0; i < 10; i++)
                    myMachine.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}",
                  e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("\n-> Custom Data:");
             
            }

            // The error has been handled, processing continues with the next statement.
           
            Console.ReadLine();

        }
    }
}
