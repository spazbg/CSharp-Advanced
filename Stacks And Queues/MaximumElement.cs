using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MaximumElement
{
    public class MaximumElement
    {
        public static void Main()
        {
            var numberOfQueries = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxNums = new Stack<int>();
            var maxNum = int.MinValue;

            for (int i = 0; i < numberOfQueries; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (input.Length > 1)
                {
                    stack.Push(input[1]);
                    if (input[1] > maxNum)
                    {
                        maxNum = input[1];
                        maxNums.Push(input[1]);
                    }
                }

                else if (input[0] == 2)
                {
                    var removeElement = stack.Pop();
                    if (removeElement == maxNum)
                    {
                        maxNums.Pop();
                        if (maxNums.Count() != 0)
                        {
                            maxNum = maxNums.Peek();
                        }
                        else
                        {
                            maxNum = int.MinValue;
                        }
                    }
                }

                else
                {
                    Console.WriteLine(maxNum);
                }
            }
        }
    }
}
