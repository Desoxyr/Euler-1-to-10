﻿using System;

namespace Euler_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            LatticePathCalculator grid = new LatticePathCalculator(20);
            Console.WriteLine("Amount of routes:" + grid.AmountOfRoutes);
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms");
        }
    }
}