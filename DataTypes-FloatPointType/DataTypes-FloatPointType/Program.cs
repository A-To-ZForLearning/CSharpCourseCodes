using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_FloatPointType
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;

            Console.WriteLine("Min Value = {0} Max Val = {1}", flMin, flMax);


            float flVar = 1F / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;

            Console.WriteLine("\nflaot value = {0}\ndoubel Value ={1}\ndeciaml Value ={2}", flVar, dlVar, dcVar);
            Console.ReadKey();




      /* for more information go to A-To-Z ForLearning channel in this link https://goo.gl/7SCOj3 */

        }
    }
}
