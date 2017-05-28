using System;
using System.Collections.Generic;
using System.Linq;

namespace _02BasicStackOperations
{
    public class BasicStackOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var stack = new Stack<int>();
 
            var elementsToPush = input[0];
            var elementsToPop = input[1];
            var checkElement = input[2];

            var integersToPush = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(integersToPush[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();

            }

            if (stack.Count>0 && stack.Contains(checkElement))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
            
        }
    }
}
