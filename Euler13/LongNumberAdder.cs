﻿using System;

 namespace Euler13
{
    public static class LongNumberAdder
    {
        public static string Add(string firstNumber, string secondNumber)
        {
            string longerNumber = firstNumber.Length >= secondNumber.Length ? firstNumber : secondNumber; 
            string shorterNumber = firstNumber.Length < secondNumber.Length ? firstNumber : secondNumber;
            
            
            string answer = "";
            bool carryOver = false;
            
            for (int index = 1 ; index <= longerNumber.Length; index++)
            {
                int firstDigit = ConvertCharToInt(longerNumber[^index]);
                int secondDigit = FindSecondDigit(shorterNumber, index, shorterNumber.Length - index >= 0);
                int addedDigit = firstDigit + secondDigit;
                
                if (carryOver)
                    addedDigit++;
                carryOver = addedDigit >= 10;
                int lastDigit = addedDigit % 10;
                answer = Convert.ToString(lastDigit) + answer;
            }

            if (carryOver)
                answer = HandleCarryOver(longerNumber.Length == shorterNumber.Length, answer);

            return answer;
        }

        private static int ConvertCharToInt(char c)
        {
            return Int16.Parse(Convert.ToString(c));
        }

        private static int FindSecondDigit(string num, int index, bool validIndex)
        {
            int secondDigit = 0;
            if (validIndex)
                secondDigit = ConvertCharToInt(num[^index]);
            return secondDigit;
        }

        private static string HandleCarryOver(bool equalLength, string answer)
        {
            if (equalLength)
                answer = "1" + answer.Substring(0);
            else
                answer = Convert.ToString(ConvertCharToInt(answer[0]) + 1) + answer.Substring(0);
            
            return answer;
        }
    }
}