using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler
{
    public class problem_12_factored_triangle
    {
        private static long Triangle(long n)
        {
            var runningTotal = 0L;
            for (var i = 1; i <= n; i++)
            {
                runningTotal += i;
            }
            return runningTotal;
        }

        public static long[] FactoriseTriangle(long n)
        {
            var factors = new List<long>();
            //factors.Add(n);
            var triangle = Triangle(n);

            for (var i = 1; i <= (triangle/2)+1; i++)
            {
                if (triangle%i == 0)
                {
                    factors.Add(i);
                }
            }
            return factors.ToArray();
        }
    }
}
