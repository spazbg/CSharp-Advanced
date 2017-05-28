using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculatorLab
{
    class SimpleCalculator
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var stack = new Stack<string>(input.Reverse());

            var total = int.Parse(stack.Pop());

            while (stack.Count > 1)
            {
                var oper = stack.Pop();
                int b = int.Parse(stack.Pop());

                if (oper == "+")
                {
                    total += b;
                }
                else
                {
                    total -= b;
                }
            }

            Console.WriteLine(total);
        }
    }
}
