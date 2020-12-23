using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(FindSmallestFactorialInefficiently());
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}ms");
            
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(FindSmallestFactorialEfficiently(20));
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}ms");
        }

        private static int FindSmallestFactorialInefficiently()
        {
            int count = 0;
            while (true)
            {
                bool isDivisable = true;
                for (int divider = 2; divider < 20; divider++)
                {
                    if (count % divider != 0)
                    {
                        isDivisable = false;
                        break;
                    }
                }
                if (isDivisable == true && count != 0)
                    return count;
                
                count += 20;
            }
        }

        private static ulong FindSmallestFactorialEfficiently(int maxNumber)
        {
            if (maxNumber > 46)
                return 0;
            
            List<int> primes = FindPrimes(maxNumber);
            List<int> multiplyNumbers = new List<int>(primes);
            for (int count = 2; count < maxNumber; count++)
            {
                if (primes.Contains(count))
                {
                    if (count * count > maxNumber)
                        break;

                    int number = count;
                    while (number * count <= maxNumber)
                    {
                        multiplyNumbers.Add(count);
                        number *= count;
                    }
                }
            }

            ulong smallestFactorial = 1;
            foreach (int prime in multiplyNumbers)
            {
                smallestFactorial = smallestFactorial * Convert.ToUInt64(prime);
            }
            
            return smallestFactorial;
        }
        
        private static List<int> FindPrimes(int limit)
        {
            List<int> primes = new List<int>();
            for (int count = 2; count <= limit; count++)
            {
                bool isPrime = true;
                for (int divider = count - 1; divider > 1; divider--)
                {
                    if (count % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                    primes.Add(count);
            }
            return primes;
        }
    }
}