using System;
using System.Collections.Generic;

namespace Euler2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacciNumbers = new List<int>() {1, 2};
            int pointer = 0;
            int limit = 4000000;
            
            while (fibonacciNumbers[pointer] + fibonacciNumbers[pointer + 1] < limit)
            {
                fibonacciNumbers.Add(fibonacciNumbers[pointer] + fibonacciNumbers[pointer + 1]);
                pointer++;
            }

            int sumOfEvenFibonacciNumbers = 0;
            foreach (var number in fibonacciNumbers)
            {
                if (number % 2 == 0)
                    sumOfEvenFibonacciNumbers += number;
            }
            Console.WriteLine($"Sum: {sumOfEvenFibonacciNumbers}");
        }
    }
}