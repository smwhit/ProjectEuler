using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler
{
    public class problem_10_sum_of_primes
    {
        public static void sum_of_primes()
        {
            var primes = problem_7_find_prime.Sieve(2000000);
            var sum = primes.Sum(x=> Convert.ToInt64(x));
            Console.WriteLine(sum);
        }
    }
}
