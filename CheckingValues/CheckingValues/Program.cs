using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 4, 7, 4, 2, 7, 3, 2 };
            int[] MinValIndices;
            int x = 7, y = 3;
            int MinVal = Minima(testArray, out MinValIndices);
            WriteLine($"Minimum value {MinVal} found at element indices:");
            foreach (int index in MinValIndices)
            {
                WriteLine(index);
            }
            ReadKey();
        }
        static int Minima(int[] integers, out int[] indices)
        {
            Debug.WriteLine("Minimum value search started.");
            indices = new int[1];
            int MinVal = integers[0];
            indices[0] = 0;
            int count = 1;
            Debug.WriteLine(string.Format(
            $"Minimum value initialized to {MinVal}, at element index 0."));
            for (int i = 1; i < integers.Length; i++)
            {
                Debug.WriteLine(string.Format(
                $"Now looking at element at index {i}."));
                if (integers[i] > MinVal)
                {
                    MinVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    Debug.WriteLine(string.Format(
                    $"New Minimum found. New value is {MinVal}, at element index { i}."));
                }
                else
                {
                    if (integers[i] == MinVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices, 0);
                        indices[count - 1] = i;
                        Debug.WriteLine(string.Format(
                        $"Duplicate Minimum found at element index {i}."));
                    }
                }
            }
            Trace.WriteLine(string.Format(
            $"Minimum value {MinVal} found, with {count} occurrences."));
            Debug.WriteLine("Minimum value search completed.");
            return MinVal;
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