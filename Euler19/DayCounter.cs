﻿using System;

namespace Euler_19
{
    public static class DayCounter
    {
        public static int CountFirstOfMonthDays(DateTime startDate, DateTime endDate, DayOfWeek day)
        {
            int amount = 0;
            while (startDate <= endDate)
            {
                if (startDate.DayOfWeek == day && startDate.Day == 1)
                    amount++;
                startDate = startDate.AddMonths(1);
                
            }
            return amount;
        }
    }
}