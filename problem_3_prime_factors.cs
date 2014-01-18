using System.Collections.Generic;

namespace project_euler
{
    public class problem_3_prime_factors
    {
        public static long[] PrimeFactors(long n)
        {
            var prime = 2;
            var factors = new List<long>();

            while (prime <= n)
            {
                if (n == prime)
                {
                    factors.Add(prime);
                    break;
                }

                if (n % prime == 0)
                {
                    factors.Add(prime);
                    n = n / prime;
                }
                else
                {
                    while (!(IsPrime(++prime))) { }
                }
            }

            return factors.ToArray();
        }

        private static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;

            var divisor = 2;
            
            while ((n / divisor) >= divisor)
            {
                if (n % divisor == 0)
                    return false;
                divisor++;
            }

            return true;
        }
    }
}
