using System;

namespace DailyCostOfMAX
{
    class Program
    {
        static void Main(string[] args)
        {
            // We're calculating the cost of MAX with decimal points this time.

            var DaysOfMax = 65;
            var CostOfMax = 15500m;
            var PricePerDay = CostOfMax / DaysOfMax;
            Console.WriteLine($"The daily cost of MAX boot camp is {Math.Round(PricePerDay, 2)} dollars per day.");

        }
    }
}

