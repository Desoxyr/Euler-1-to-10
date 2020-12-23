﻿using System;
using System.Diagnostics;
using System.IO;

namespace Euler_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("Input.txt");
           
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            PathSumCalculator calculator = new PathSumCalculator(input);
            Console.WriteLine($"Highest Sum: {calculator.GetHighestSum()}");
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}