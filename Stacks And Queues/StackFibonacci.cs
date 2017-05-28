using System;
using System.Collections.Generic;
using System.Linq;

namespace _09StackFibonacci
{
    public class StackFibonacci
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var fibNumbers = new Stack<long>();

            fibNumbers.Push(0);
            fibNumbers.Push(1);

            for (int i = 2; i <= input; i++)
            {
                long previousNum = fibNumbers.Pop();
                long prevPrevNum = fibNumbers.Peek();
                fibNumbers.Push(previousNum);
                long result = previousNum + prevPrevNum;
                fibNumbers.Push(result);
            }

            Console.WriteLine(fibNumbers.Peek());
        }
    }
}
