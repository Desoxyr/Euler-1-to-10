using System;
using System.Diagnostics;
using System.Linq;

namespace Euler10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ulong a = FindSumOfPrimes(1999999);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + "ms");
            Console.WriteLine(a);

        }

        private static ulong FindSumOfPrimes(int maximum)
        {
            bool[] boolArray = Enumerable.Repeat(true, maximum).ToArray();

            var ceiling = Math.Ceiling(Math.Sqrt(maximum));
            for (int i = 2; i < ceiling; i++)
            {
                if (boolArray[i])
                {
                    for (int j = i*i; j < maximum; j+=i)
                    {
                        boolArray[j] = false;
                    }
                }   
            }
            
            ulong sum = 0;
            
            for (int i = 2; i < maximum; i++)
            {
                if (boolArray[i] == true)
                    sum += (ulong) i;
            }
            
            return sum;
        }
    }
}