﻿using System.Numerics;

namespace Euler_20
{
    public class SumOfDigitFinder
    {
        public static int FindSum(BigInteger num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += (int) (num % 10);
                num /= 10;
            }
            return sum;
        }
    }
}