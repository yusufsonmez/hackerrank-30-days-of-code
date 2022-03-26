using System;

namespace Hackerrank_30daysofcode
{
    class Day14
    {

                private int[] elements;
                public int maximumDifference;

                // Add your code here
                public Day14(int[] arrays)
                {
                    elements = arrays;
                }
                public void computeDifference()
                {

                    var min = int.MaxValue;
                    var max = int.MinValue;

                    for (var i = 0; i < elements.Length; i++)
                    {
                        min = Math.Min(min, elements[i]);
                        max = Math.Max(max, elements[i]);
                    }
                    maximumDifference = max - min;
                   Console.WriteLine(maximumDifference);
                   Console.ReadLine();
                }

            } // End of Difference Class
        }
        
