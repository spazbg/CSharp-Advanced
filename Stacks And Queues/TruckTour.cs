using System;
using System.Collections.Generic;
using System.Linq;

namespace _06TruckTour
{
    public class TruckTour
    {
        public static void Main()
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            int startPump = 0;
            int fuelLeft = 0;

            for (int i = 0; i < numberOfPumps; i++)
            {
                List<int> input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                int newFuel = input[0];
                int distanceToNext = input[1];

                fuelLeft += newFuel;

                if (fuelLeft >= distanceToNext)
                {
                    fuelLeft -= distanceToNext;
                }
                else
                {
                    startPump = i + 1;
                    fuelLeft = 0;
                }

            }

            Console.WriteLine($"{startPump}");
        }
    }
}



