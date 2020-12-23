﻿using System;

namespace Euler_11
{
    public class Line
    {
        public int[] Numbers;

        public Line(string input)
        {
            Numbers = Array.ConvertAll(input.Split(" "), int.Parse);
        }
    }
}