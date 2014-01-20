using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler
{
    public class problem_7_find_prime
    {
        public static int[] Sieve(long end)
        {
            var primes = new bool[end];

            for (var i = 2L; i < end; i++)
            {
                primes[i] = true;
            }

            for (var i = 4L; i < end; i += 2)
            {
                primes[i] = false;
            }

            for (var i = 3L; i < end / 2; i++)
            {
                for (var j = i + i; j < end; j += i)
                {
                    if (j % i == 0) primes[j] = false;
                }
            }

            return primes.Select((x, index) => new { OriginalIndex = index, IsPrime = x }).Where(x => x.IsPrime).Select(x => x.OriginalIndex).ToArray();

        }
    }
}
