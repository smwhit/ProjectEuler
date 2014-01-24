using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler
{
    public class problem_14_longest_collatz
    {
        public static void longest_collatze_under_one_million()
        {
            const int number = 1000000;

            long sequenceLength = 0;
            long startingNumber = 0;
            long sequence;

            for (int i = 2; i <= number; i++)
            {
                int length = 1;
                sequence = i;
                while (sequence != 1)
                {
                    if ((sequence % 2) == 0)
                    {
                        sequence = sequence / 2;
                    }
                    else
                    {
                        sequence = sequence * 3 + 1;
                    }
                    length++;
                }

                //Check if sequence is the best solution
                if (length > sequenceLength)
                {
                    sequenceLength = length;
                    startingNumber = i;
                }
            }

            var col = collatz(13);
            var maxCollatzLength = 0L;
            var longestNumber = 0L;
            long[] c;

            for (var i = 1; i <= 1000000; i++)
            {
                c = collatz(i);
                if (c.Length > maxCollatzLength)
                {
                    longestNumber = i;
                    maxCollatzLength = c.Length;
                }
            }
            Console.WriteLine(maxCollatzLength);
            Console.WriteLine(longestNumber);
        }

        public static long[] collatz(long n)
        {
            var ns = new List<long>();
            
            while (n != 1)
            {
                ns.Add(n);

                if (n%2 == 0)
                {
                    n = n/2;
                }
                else
                {
                    checked
                    {
                        n = n*3 + 1;
                    }
                }

                if(n > int.MaxValue) Console.WriteLine("Wowsers - {0}", n);
            }
            ns.Add(1);
            return ns.ToArray();
        }
    }
}
