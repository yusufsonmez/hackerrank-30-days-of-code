using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_30daysofcode
{
    class Day3
    {

        public void SolutionDay3(){
            
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        if(N%2 == 1){
            Console.WriteLine("Weird");
        }
        else if(N%2 == 0 && (N<=5 && N>=2)){
            Console.WriteLine("Not Weird");
        }
        else if(N%2 == 0 && (N<=20 && N>=6)){
            Console.WriteLine("Weird");
        }
        else if(N%2 == 0 && N>20){
            Console.WriteLine("Not Weird");
        }
        else
            Console.WriteLine("Try again");

        Console.ReadLine();

        }
    }
}
