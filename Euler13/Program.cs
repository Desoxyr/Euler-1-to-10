using System;
using System.IO;

namespace Euler13
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            string[] input = File.ReadAllLines("Input.txt");
            string answer = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                answer = LongNumberAdder.Add(answer, input[i]);
            }
            Console.WriteLine(answer);
                
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms");
        }
    }
}