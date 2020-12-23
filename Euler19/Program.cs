﻿using System;
using System.Diagnostics;

namespace Euler_19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime startDate = new DateTime(1901,1,1);
            DateTime endDate = new DateTime(2000, 12, 31);
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            int answer = DayCounter.CountFirstOfMonthDays(startDate, endDate, DayOfWeek.Sunday);
            stopwatch.Stop();
            
            Console.WriteLine($"There were {answer} Sundays in the twentieth century");
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}ms");
            
        }
    }
}