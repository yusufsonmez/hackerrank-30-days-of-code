using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_30daysofcode
{
    class Day5
    {
        public void SolutionDay5(int a){
            Boolean active=true;
            while (active) { 
            a = Convert.ToInt32(Console.ReadLine());
            if(a>=2 && a<=20){
            for(int i=1;i<=10;i++){
                 Console.WriteLine(a + " x " + i + " = " + a* i);
                }
            }
            }
            Console.ReadLine();

        }
    }
}
