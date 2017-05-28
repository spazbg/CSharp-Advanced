using System;
using System.Collections.Generic;
using System.Linq;

namespace _04BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main()
        {
            var inputParams = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var elements = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            var elementsToPush = inputParams[0];
            var elementsToPop = inputParams[1];
            var elementToCheck = inputParams[2];

            for (int i = 0; i < elementsToPush; i++)
            {
                queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count > 0 && queue.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
