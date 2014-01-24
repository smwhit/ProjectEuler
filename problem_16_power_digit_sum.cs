using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace project_euler
{
    public class problem_16_power_digit_sum
    {
        public static void sum_of_digits_two_power_1000()
        {
            var b = new BigInteger(1);

            for (var p = 1; p <= 1000; p ++)
            {
                b *= 2;
            }

            var chars = b.ToString();
            var sum = "";
            foreach (var c in chars)
            {
                sum += (c -char.Parse("0")) ;
            }

            var runningTotal = 0;
           
            foreach (var i in sum)
            {
                runningTotal += int.Parse(i.ToString());
            }
        }
    }
}
