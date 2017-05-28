using System;
using System.Collections.Generic;
using System.Linq;

namespace _01ReverseNumbers
{
    public class ReverseNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 1)
            {
                Console.Write(stack.Pop()+" ");
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
