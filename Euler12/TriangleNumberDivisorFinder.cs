﻿using System;

namespace Euler_12
{
    public static class TriangleNumberDivisorFinder
    {
        public static int FindMinimumDivisors(int amount)
        {
            int count = 0;
            int addition = 1;    
            while (FindNumberOfDivisors(count) < amount)
            {
                count += addition;
                addition++;
            }
            return count;
        }

        private static int FindNumberOfDivisors(int number)
        {
            int amount = 0;
            int max = Convert.ToInt32 (Math.Sqrt(number));
            for (int i = 1; i <= max; i++)
            {
                if (number % i == 0)
                    amount += 2;
            }

            if (max * max == number)
                amount--;
            
            return amount;
        }
    }
}