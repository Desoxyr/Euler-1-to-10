using System;
using System.IO;
using Euler_11;

namespace Euler11
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Grid grid = new Grid(File.ReadAllLines("Input.txt"));
            int answer = grid.FindHighestProduct(4);
            Console.WriteLine(answer);
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms");
        }
    }
}