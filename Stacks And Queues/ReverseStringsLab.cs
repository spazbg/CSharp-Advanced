using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStringsLab
{
    class ReverseStringsLab
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = stack.Count; i > 0; i--)
            {
                var currChar = stack.Pop();
                Console.Write(currChar);
            }

            Console.WriteLine();
        }
    }
}
