﻿using System.Numerics;

namespace Euler_20
{
    public static class FactorialFinder
    {
        public static BigInteger GetNumber(int number)
        {
            BigInteger answer = 1;
            for (int i = number; i >= 2; i--)
            {
                answer *= i;
            }
            return answer;
        }
    }
}