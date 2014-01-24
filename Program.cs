using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace project_euler
{
    class Program
    {
        static void Main(string[] args)
        {
            problem_16_power_digit_sum.sum_of_digits_two_power_1000();
            //problem_14_longest_collatz.longest_collatze_under_one_million();

            //long factorLength = 0;
            //var i = 1;
            //var maxFactorLength = 0L;

            //do
            //{
            //    long[] factoriseTriangle = problem_12_factored_triangle.FactoriseTriangle(i);   
            //    factorLength  = factoriseTriangle.Length;
            //    if (factorLength > maxFactorLength)
            //    {
            //        maxFactorLength = factorLength;
            //        Console.WriteLine("Current max length is {0} for {1}", maxFactorLength, i);
            //    }

            //    i++;

            //} while (factorLength < 500);


            //problem_10_sum_of_primes.sum_of_primes();

            //problem_5_remainder.FindSmallNumberDivisibleByNumbersUpTo20();
            //problem_6_sum_squares_difference.SumSquaresVsSquaresSum();

            //Console.WriteLine(problem_7_find_prime.Sieve(2000000)[10000]);
            //problem2_fibonacci.SumOfEvenFibsUpToFourMillion();

            //problem1_multiples.SumOfMultiplesOf3And5Below1000();

            //Console.WriteLine("Prime factors of {1} are {0}", string.Join(" ", problem_3_prime_factors.PrimeFactors(13195)), 13195);
            //Console.WriteLine("Prime factors of {1} are {0}", string.Join(" ", problem_3_prime_factors.PrimeFactors(600851475143)), 600851475143);

            //problem4_palindrome.BruteForcePalindrome();
        }

        private static int GeneratePalindrome(int number)
        {
            var reversedNumber = new string( number.ToString().Reverse().ToArray());

            return Convert.ToInt32( number + reversedNumber);
        }
    }
}
