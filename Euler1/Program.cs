using System;

namespace Euler
{
    static class Program
    {
        public static void Main(string[] args)
        {
            int total = 0;
            for (int count = 0; count < 1000; count++)
            {
                if (count % 3 == 0 || count % 5 == 0)
                    total += count;
            }
            Console.WriteLine("Total " + total);
        }
    }
}