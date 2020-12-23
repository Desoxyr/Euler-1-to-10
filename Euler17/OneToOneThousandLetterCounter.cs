﻿namespace Euler_17
{
    public class OneToOneThousandLetterCounter
    {
        private const int OneToNine = 36;
        private const int TenToNineteen = 70;
        private const int TenMultiplesTwentyToNinety = 46;
        private const int TwentyToNinetyNine = TenMultiplesTwentyToNinety * 10 + OneToNine * 8;
        private const int OneToNinetyNine = TwentyToNinetyNine + OneToNine + TenToNineteen;
        private const int Hundred = 7;
        private const int And = 3;
        private const int Thousand = 8;
        
        public int GetSolution()
        {
            int answer = 0;
            answer += OneToNine * 100;
            answer += OneToNinetyNine * 10;
            answer += Hundred * 900;
            answer += And * 891;
            answer += Thousand;
            return answer;
        }
    }
}