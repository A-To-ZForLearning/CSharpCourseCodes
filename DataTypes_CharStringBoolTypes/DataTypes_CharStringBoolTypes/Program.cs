﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;

            char myVar = 'G';
            int myVarValue = 'G';

            char myVarValue2 = Convert.ToChar(75);

            Console.WriteLine("Min Char = {0} Max Char = {1}  My Character = {2} my Variable Number = {3} my Conversion value is = {4}",
                charMin, charMax, myVar, myVarValue, myVarValue2);


            string myString = "This is my variable";
            Console.WriteLine("\nMy String is {0}", myString);

            bool myBool = false;
            Console.WriteLine("my boolean value is {0}", myBool);

            Console.ReadKey();
			
			 /* for more information go to A-To-Z For LEarning channel in this link https://goo.gl/7SCOj3 */
        }
    }
}
