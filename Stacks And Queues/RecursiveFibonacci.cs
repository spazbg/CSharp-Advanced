using System;
using System.Collections.Generic;
using System.Linq;

namespace _08RecursiveFibonacci
{
    public class RecursiveFibonacci
    {
        private static long[] fibNumbers;

        public static void Main()
        {
            var nthNumber = long.Parse(Console.ReadLine());

            fibNumbers = new long[nthNumber];

            var result = GetFibonacci(nthNumber);

            Console.WriteLine(result);
        }

        private static long GetFibonacci(long nthNumber)
        {
            if (nthNumber <= 2)
            {
                return 1;
            }
            if (fibNumbers[nthNumber - 1] != 0)
            {
                return fibNumbers[nthNumber - 1];
            }

            return fibNumbers[nthNumber - 1] = GetFibonacci(nthNumber - 1) + GetFibonacci(nthNumber - 2);
        }
    }
}
