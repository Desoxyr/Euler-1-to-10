using System;

namespace Euler9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FindProduct());
        }

        private static int FindProduct()
        {
            for (int c = 1000; c > 0; c--)
            {
                for (int b = 999 - c; b > 1; b--)
                {
                    int a = 1000 - c - b;
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine($"A: {a}, B:{b}, C:{c}");
                        return a * b * c;
                    }
                }
            }
            return 0;
        }
    }
}