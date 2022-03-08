using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_30daysofcode
{
    class Day4
    {
        int age;

        public void SolutionDay4(int initialAge)
        {
     
            // Add some more code to run some checks on initialAge
            if (initialAge >= 0)
            {
                age = initialAge;
                amIOld(age);
            }
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            Console.ReadLine();
        }
        public void amIOld(int age)
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
            // Do some computations in here and print out the correct statement to the console 
            Console.ReadLine();
        }
        
    }

}
