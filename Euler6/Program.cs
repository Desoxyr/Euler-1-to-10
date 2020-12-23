using System;
using System.Diagnostics;

namespace Euler6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine($"Difference: {FindDifference(1, 100)}");
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds} ms");
        }

        //Find the difference between the sum of a square and the square of a sum
         private static int FindDifference(int minimum, int maximum)
        {
            int sumOfSquare = 0;
            int squareOfSum = 0;
            for (int i = minimum; i <= maximum; i++)
            {
                sumOfSquare += i;
                squareOfSum += (i * i);
            }
            sumOfSquare *= sumOfSquare;
            return sumOfSquare - squareOfSum;
        }
    }
}