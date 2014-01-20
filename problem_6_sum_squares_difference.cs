using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler
{
    public class problem_6_sum_squares_difference
    {
        public static void SumSquaresVsSquaresSum()
        {
            var maxN = 100;
            var sumSumSquares = 0L;
            var sumSquaresSum = 0L;

            for (var i = 1; i <= maxN; i++)
            {
                sumSumSquares += Convert.ToInt64(Math.Pow(i, 2));
                sumSquaresSum += i;
            }

            var totalSumSquares = Math.Pow(sumSquaresSum, 2);

            Console.WriteLine("Difference is {0}", (totalSumSquares - sumSumSquares));

            Console.WriteLine(totalSumSquares);
            Console.WriteLine(sumSumSquares);
        }
    }
}
