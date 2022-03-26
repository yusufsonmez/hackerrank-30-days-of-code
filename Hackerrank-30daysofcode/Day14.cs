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

                for (int i = 0; i < elements.Length; i++)
                {
                    if (elements[i] > max)
                    {
                        max = elements[i];
                    }
                    if (elements[i] < min)
                    {
                        min = elements[i];
                    }
                }
                   maximumDifference = max - min;
                   Console.WriteLine(maximumDifference);
                   Console.ReadLine();
                }

            } // End of Difference Class
        }
        
