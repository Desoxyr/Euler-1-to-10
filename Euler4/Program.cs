using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Euler4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            FindLargestPalindrome();
            stopwatch.Stop();
            Console.WriteLine($"Time Method 1: {stopwatch.ElapsedMilliseconds}ms");

            stopwatch.Reset();
            stopwatch.Start();
            FindLargestPalindrome2();
            stopwatch.Stop();
            Console.WriteLine($"Time Method 2: {stopwatch.ElapsedMilliseconds}ms");
        }
        
         //Method 1: less efficient because it loops through all possibilities
        private static void FindLargestPalindrome()
        {
            List<int> palindromes = new List<int>();
            for (int count = 999; count >= 100; count--)
            {
                for (int count2 = 999; count2 >= 100; count2--)
                {
                    if (CheckIfPalindrome(count * count2))
                        palindromes.Add(count * count2);
                }
            }

            Console.WriteLine($"Largest palindrome: {palindromes.Max()}");
        }

        private static bool CheckIfPalindrome(int i)
        {
            string number = Convert.ToString(i);

            for (int digit = 0; digit < number.Length / 2; digit++)
            {
                if (number[digit] != number[number.Length - 1 - digit])
                    return false;
            }

            return true;
        }

        //Method 2: Much more efficient. First defines possible palindromes then checks from biggest to smallest
        private static void FindLargestPalindrome2()
        {
            //Create list of all palindromes with 5 and 6 digits
            List<int> palindromes = new List<int>();
            for (int firstDigit = 9; firstDigit >= 1; firstDigit--)
            {
                for (int secondDigit = 9; secondDigit >= 0; secondDigit--)
                {
                    for (int thirdDigit = 9; thirdDigit >= 0; thirdDigit--)
                    {
                        palindromes.Add(int.Parse(firstDigit.ToString() + secondDigit + thirdDigit
                                                  + thirdDigit + secondDigit + firstDigit));
                        palindromes.Add(int.Parse(firstDigit.ToString() + secondDigit + thirdDigit
                                                  + secondDigit + firstDigit));
                    }
                }
            }

            LoopThroughPalindromes(palindromes);
        }

        private static void LoopThroughPalindromes(List<int> palindromes)
        {
            palindromes = palindromes.OrderByDescending(p => p).ToList();
            foreach (var palindrome in palindromes)
            {
                for (int count = 999; count >= 100; count--)
                {
                    if (palindrome / count > 999)
                        break;
                    if (palindrome % count == 0)
                    {
                        Console.WriteLine($"Largest palindrome: {palindrome}");
                        Console.WriteLine($"Numbers: {count} and {palindrome / count}");
                        return;
                    }
                }
            }
        }
    }
}