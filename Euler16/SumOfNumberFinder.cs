﻿using System;
using System.Numerics;

namespace Euler_16
{
    public static class SumOfNumberFinder
    {
        public static int FindSumOfNumbers(BigInteger number)
        {
            string numberAsString = Convert.ToString(number);
            int answer = 0;
            for (int i = 0; i < numberAsString.Length; i++)
            {
                answer += int.Parse(Convert.ToString(numberAsString[i]));
            }
            return answer;
        }
    }
}