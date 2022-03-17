using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_30daysofcode
{
    class Day10
    {



   



public void SolutionDay10(int n)
    {
       
            //n = Convert.ToInt32(Console.ReadLine().Trim());
            var max = 0;
            var countOfI = 0;

            while (n > 0)
            {


                if (n % 2 == 1)
                {
                    countOfI++;
                    if (countOfI > max)
                    {
                        max = countOfI;
                    }
                }
                else
                {
                    countOfI = 0;
                }

                n = n / 2;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    


}
}
