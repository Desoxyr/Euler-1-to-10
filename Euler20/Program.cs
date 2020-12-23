﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace Euler_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            BigInteger factorial = FactorialFinder.GetNumber(100);
            int answer = SumOfDigitFinder.FindSum(factorial);
            Console.WriteLine($"Sum of all digits of the factial is {answer}");
            
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}ms");
            
        }
    }
}