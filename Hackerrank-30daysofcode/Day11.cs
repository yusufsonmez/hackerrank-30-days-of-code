using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_30daysofcode
{
    class Day11
    {
        public void SolutionDay11()
        {

                List<List<int>> arr = new List<List<int>>();

                for (int i = 0; i < 6; i++)
                {
                    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                }


                int max_sum = 0;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {

                        int temp_sum = 0;
                        // top row
                        temp_sum += arr[i][j];
                        temp_sum += arr[i][j + 1];
                        temp_sum += arr[i][j + 2];
                        //middle 
                        temp_sum += arr[i + 1][j + 1];
                        //bottom row
                        temp_sum += arr[i + 2][j];
                        temp_sum += arr[i + 2][j + 1];
                        temp_sum += arr[i + 2][j + 2];

                        //if first hourglass, set as max
                        if (temp_sum > max_sum || i == 0 && j == 0)
                        {
                            max_sum = temp_sum;///this will keep it up to date
                        }
                    }
                }
                Console.WriteLine(max_sum);
                Console.ReadLine();
            }
        }
    }