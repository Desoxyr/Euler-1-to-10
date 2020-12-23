﻿using System;

namespace Euler_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            int answer = ChainManager.FindLongestChain(1000000);
            Console.WriteLine($"The longest chain starts with {answer} with a sequence of {ChainManager.HighestStartingNumber}");
            
            watch.Stop();
            Console.WriteLine("Time: " +  watch.ElapsedMilliseconds + "ms");
        }
    }
}