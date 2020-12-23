﻿using System;
using System.Numerics;

namespace Euler_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var number = BigInteger.Pow(2, 1000);
            int answer = SumOfNumberFinder.FindSumOfNumbers(number);
            Console.WriteLine($"The sum of the numbers is {answer}");
            watch.Stop();
            Console.WriteLine($"Time: {watch.ElapsedMilliseconds}ms");
            
            
        }
    }
}