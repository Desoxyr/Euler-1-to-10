using System;
using System.Diagnostics;

namespace Euler3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("---");
            Console.WriteLine($"Largest factor: {FindLargestPrimeFactor(600851475143)}");
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds} ms");
        }

        private static long FindLargestPrimeFactor(long largestPrimeFactor)
        {
            long largestPrime = 0;
            for (long count = 2; count < largestPrimeFactor + 1;)
            {
                if (largestPrimeFactor % count == 0)
                {
                    largestPrimeFactor /= count;
                    largestPrime = count;
                    Console.WriteLine("Found new largest factor: " + count);
                }
                else
                    count++;
                
            }
            return largestPrime;
        }
    }
}