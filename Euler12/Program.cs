using System;
using Euler_12;

namespace Euler12
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int answer = TriangleNumberDivisorFinder.FindMinimumDivisors(500);
            Console.WriteLine(answer);
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms");
        }
    }
}