using System;
using System.Linq;

namespace project_euler
{
    public class problem4_palindrome
    {
        public static void BruteForcePalindrome()
        {
            var maxPalindrome = 0;
            var maxX = 0;
            var maxY = 0;

            for (var x = 1; x <= 999; x++)
            {
                for (var y = 1; y <= 999; y++)
                {
                    var product = x * y;
                    if (IsPalindrome(product))
                    {
                        if (product > maxPalindrome)
                        {
                            maxPalindrome = product;
                            maxX = x;
                            maxY = y;
                        }
                        Console.WriteLine(product);
                    }
                }
            }

            Console.WriteLine("Largest palindrome found is {0} which is the product of {1} and {2}", maxPalindrome, maxX, maxY);
        }

        private static bool IsPalindrome(int product)
        {
            var productString = product.ToString();
            return productString == new string(productString.Reverse().ToArray());
        }
    }
}
