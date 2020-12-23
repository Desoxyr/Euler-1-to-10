using System;
using System.Diagnostics;
using System.IO;

namespace Euler8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            string input = File.ReadAllText("Number.txt").Replace("\r", "").Replace("\n", "");
            ulong[] intArray = Array.ConvertAll(input.ToCharArray(), c => (ulong) Char.GetNumericValue(c));
            
            Console.WriteLine(FindLargestProductSimple(intArray));
            stopwatch.Stop();
            Console.WriteLine($"Time for milan {stopwatch.Elapsed.TotalMilliseconds}ms");
        }
        private static ulong FindLargestProductSimple(ulong[] number)
        {
            ulong largestSequence = 0;

            for (int pointer = 0; pointer <= number.Length - 13;)
            {
                ulong sequence = number[pointer];
                for (int multiplyPointer = 1; multiplyPointer < 13; multiplyPointer++)
                {
                    sequence *= number[pointer + multiplyPointer];
                }
                if (sequence > largestSequence)
                    largestSequence = sequence;

                pointer++;
            }
            return largestSequence;
        }
    }
}