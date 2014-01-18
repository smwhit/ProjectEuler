using System;
using System.Linq;

namespace project_euler
{
    class Program
    {
        static void Main(string[] args)
        {
            problem1_multiples.SumOfMultiplesOf3And5Below1000();

            Console.WriteLine("Prime factors of {1} are {0}", string.Join(" ", problem_3_prime_factors.PrimeFactors(13195)), 13195);
            Console.WriteLine("Prime factors of {1} are {0}", string.Join(" ", problem_3_prime_factors.PrimeFactors(600851475143)), 600851475143);

            //problem4_palindrome.BruteForcePalindrome();
        }

        private static int GeneratePalindrome(int number)
        {
            var reversedNumber = new string( number.ToString().Reverse().ToArray());

            return Convert.ToInt32( number + reversedNumber);
        }
    }
}
