using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_30daysofcode
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Student day12 = new Student("Feyyaz", "Yigit", 2452, new int[] { 100,80});
            day12.printPerson();
            Console.WriteLine("Grade: " + day12.Calculate());
            Console.ReadLine();



            //Day11 day11 = new Day11();
            //day11.SolutionDay11();
            // Sample input for day11
            //-1 1 - 1 0 0 0
            //0 - 1 0 0 0 0
            //- 1 - 1 - 1 0 0 0
            //0 - 9 2 - 4 - 4 0
            //- 7 0 0 - 2 0 0
            //0 0 - 1 - 2 - 4 0



            //Day10 day10 = new Day10();
            //day10.SolutionDay10(5);



            //Day9 day9 = new Day9();
            //Console.WriteLine(day9.SolutionDay9(5));
            //Console.ReadLine();
        }
    }
}
