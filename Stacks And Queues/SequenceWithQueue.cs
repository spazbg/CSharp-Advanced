using System;
using System.Collections.Generic;
using System.Linq;

namespace _05SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main()
        {
            var firstElement = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();

            queue.Enqueue(firstElement);
            var counter = 0;
            while (queue.Count < 50)
            {
                var currentQueue = new Queue<long>();

                var secondElement = firstElement + 1;
                var thirdElement = 2 * firstElement + 1;
                var fourthElement = firstElement + 2;

                currentQueue.Enqueue(secondElement);
                currentQueue.Enqueue(thirdElement);
                currentQueue.Enqueue(fourthElement);

                while (queue.Count < 50 && currentQueue.Count > 0)
                {
                    queue.Enqueue(currentQueue.Dequeue());
                }
                counter++;
                firstElement = queue.ToArray()[counter];
            }

            Console.WriteLine(string.Join(" ", queue.ToArray()));
        }
    }
}
