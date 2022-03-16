using System;


namespace Hackerrank_30daysofcode
{
    class Day9
    {
            
            //factorial
            public int SolutionDay9(int n)
            {
                if (n > 1)
                {
                    n = n * SolutionDay9(n - 1);

                }
            return n;
            }



    }
}
