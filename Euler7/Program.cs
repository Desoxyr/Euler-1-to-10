using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<int> a = FindPrimes(10001);
            Console.WriteLine(a[^1]);
            //Console.WriteLine(string.Join(",", a));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + "ms");
            
        }
        
        private static List<int> FindPrimes(int amount)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int count = 3;

            while (primes.Count < amount)
            {
                bool isPrime = true;
                foreach (var num in primes)
                {
                    if (count % num == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
               
                if (isPrime)
                    primes.Add(count);
                
                count = count + 2;
            }
            return primes;
        }
    }
}