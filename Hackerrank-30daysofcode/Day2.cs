using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;

namespace Hackerrank_30daysofcode
{
    class Day2
    {

       public void SolutionDay2() { 
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int secondInteger = Convert.ToInt32(Console.ReadLine());
            double secondDouble = Convert.ToDouble(Console.ReadLine());
            string secondString = Console.ReadLine();


            // Read and save an integer, double, and String to your variables.
            i = i + secondInteger;
            d = d + secondDouble;
            s = s + secondString;

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i);

            // Print the sum of the double variables on a new line.
            Console.WriteLine(d.ToString("F1"));


            // Concatenate and print the String variables on a new line
            Console.WriteLine(s);
            Console.ReadLine();
            // The 's' variable above should be printed first.
        }
    }
}