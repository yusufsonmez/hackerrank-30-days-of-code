using System;

namespace Hackerrank_30daysofcode
{
    class Day2
    {

        public void SolutionDay2(double meal_cost, int tip_percent, int tax_percent)
        {
            double my_tip_percent = meal_cost * tip_percent / 100;
            double my_tax_percent = meal_cost * tax_percent / 100;
            double sum = meal_cost + my_tip_percent + my_tax_percent;

            Console.WriteLine(Math.Round(sum));
            Console.ReadLine();
        }
    }
}