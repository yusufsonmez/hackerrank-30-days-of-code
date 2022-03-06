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
    class Day3
    {

        public void SolutionDay3(double meal_cost, int tip_percent, int tax_percent)
        {
            double my_tip_percent = meal_cost * tip_percent / 100;
            double my_tax_percent = meal_cost * tax_percent / 100;
            double sum = meal_cost + my_tip_percent + my_tax_percent;

            Console.WriteLine(Math.Round(sum));
            Console.ReadLine();
        }
    }
}