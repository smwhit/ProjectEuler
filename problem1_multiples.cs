using System;
using System.Collections.Generic;
using System.Linq;

namespace project_euler
{
    public class problem1_multiples
    {
        public static void SumOfMultiplesOf3And5Below1000()
        {
            var multiples = new List<int>();

            for (var i = 0; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    multiples.Add(i);
                }
            }

            Console.WriteLine(multiples.Sum());
        }
        
    }
}
