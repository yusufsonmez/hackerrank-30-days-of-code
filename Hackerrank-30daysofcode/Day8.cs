using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_30daysofcode
{
    class Day8
    {



public void SolutionDay8()
    {
       
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' '); //getting the key value by space separated..

                phonebook[line[0]] = line[1];    // storing the vslue to Dictionary as key = value.


            }

            string name;
            while ((name = Console.ReadLine()) != null)
            {
                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine(name + "=" + phonebook[name]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }





        
    }






}
}
