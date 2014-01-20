using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler
{
    public class problem_5_remainder
    {
        public static void FindSmallNumberDivisibleByNumbersUpTo20()
        {
            var found = false;
            var n = 2;

            while (!found)
            {
                n++;

                for (var i = 1; i <= 20; i++)
                {
                    if (n%i != 0)
                        break;

                    if (i == 20)
                        found = true;
                }
            }

            Console.WriteLine("Found it at {0}", n);

            //Console.WriteLine(2520 / 1);
            //Console.WriteLine(2520 / 2);
            //Console.WriteLine(2520 / 3);
            //Console.WriteLine(2520 / 4);
            //Console.WriteLine(2520 / 5);
            //Console.WriteLine(2520 / 6);
            //Console.WriteLine(2520 / 7);
            //Console.WriteLine(2520 / 8);
            //Console.WriteLine(2520 / 9);
            //Console.WriteLine(2520 / 10);
            
        }
    }
}
