﻿using System.Collections.Generic;
using System.Numerics;

namespace Euler_14
{
    public static class ChainManager
    {
        private static int[] _chainLengths;
        public static int MaxSequenceLength { get; private set; }
        public static int HighestStartingNumber { get; private set; }

        public static int FindLongestChain(int maximum)
        {
            MaxSequenceLength = 0; 
            HighestStartingNumber = 0;
            _chainLengths = new int[maximum + 1];
            _chainLengths[1] = 1;
            
            for (int index = 1; index <= maximum; index++)
            {
                CalculateChainLength(index);
                CheckWhetherMaxLength(index);
            }
            return HighestStartingNumber;
        }

        private static void CalculateChainLength(int index)
        {
            long number = index;
            int sequenceLength = 0;
            while (number != 1 && number >= index)
            {
                sequenceLength++;
                number = ExecuteRule(number);
            }
            _chainLengths[index] = sequenceLength + _chainLengths[number];
        }

        private static long ExecuteRule(long number)
        {
            if (number % 2 == 0) 
                number = number / 2;
            else 
                number = number * 3 + 1;
            return number;
        }

        private static void CheckWhetherMaxLength(int number)
        {
            int sequenceLength = _chainLengths[number];
            if (sequenceLength > MaxSequenceLength) {
                MaxSequenceLength = sequenceLength;
                HighestStartingNumber = number;
            }
        }
        
        public static List<long> CreateChain(int startingNumber)
        {
            List<long> chain = new List<long> {startingNumber};
            long number = startingNumber;
            while (number > 1)
            {
                number = ExecuteRule(number);
                chain.Add(number);   
            }
            return chain;
        }
    }
}