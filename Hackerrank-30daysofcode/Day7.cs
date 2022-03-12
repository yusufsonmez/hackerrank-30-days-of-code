using System.Collections.Generic;
using System.Linq;
using System;

namespace Hackerrank_30daysofcode
{
    class Day7
    {
        
public void SolutionDay7()
    {
     

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();


            for (int i = arr.Count - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        
    }



}
}
