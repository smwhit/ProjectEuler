using System;
using System.Collections.Generic;
using System.Linq;

namespace project_euler
{
    public class problem2_fibonacci
    {
        public static void SumOfEvenFibsUpToFourMillion()
        {
            var fibs = new List<int>();
            fibs.Add(0);
            fibs.Add(1);

            var previousIndex = 0;
            var currentIndex = 1;

            while (fibs[currentIndex] < 4000000)
            {
                fibs.Add(fibs[previousIndex] + fibs[currentIndex]);
                currentIndex++;
                previousIndex++;
            }

            Console.WriteLine(fibs.Where(x=>x % 2 == 0).Sum());
        }
    }
}
