using System;

namespace AlgorithmicComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Analyzing computational complexity
            Console.WriteLine("Task 1: Simulating Nested Loops");
            SimulateNestedLoops(10); 

            // Task 2: Comparing growth rates of n^2 and 2^(n/4)
            Console.WriteLine("\nTask 2: Comparing Growth Rates");
            CompareGrowthRates(20); 
        }

        // Task 1: Simulating nested loops and demonstrate operation count
        static void SimulateNestedLoops(int n)
        {
            int operationCount = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = 1; k <= j; k++)
                    {
                        operationCount++;
                        Console.WriteLine("What a great challenge!");
                    }
                }
            }

            Console.WriteLine($"Total operations for n = {n}: {operationCount}");
            Console.WriteLine("Time Complexity: O(n^3)");
        }

        // Task 2: Comparing growth rates of n^2 and 2^(n/4)
        static void CompareGrowthRates(int maxN)
        {
            Console.WriteLine("n\t\tn^2\t\t2^(n/4)");
            Console.WriteLine("------------------------------------");

            for (int n = 0; n <= maxN; n++)
            {
                double nSquared = Math.Pow(n, 2);
                double exponential = Math.Pow(2, n / 4.0);

                Console.WriteLine($"{n}\t\t{nSquared:F2}\t\t{exponential:F2}");
            }

            Console.WriteLine("\nObservation:");
            Console.WriteLine("- Initially, n^2 grows faster.");
            Console.WriteLine("- Eventually, 2^(n/4) overtakes due to its exponential growth.");
        }
    }
}
