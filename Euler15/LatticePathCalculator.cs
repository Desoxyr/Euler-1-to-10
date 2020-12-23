﻿using System;

namespace Euler_15
{
    public class LatticePathCalculator
    {
        private long[,] Grid { get; }
        
        public long AmountOfRoutes => Grid[Grid.GetLength(0) - 1, Grid.GetLength(1) - 1];

        public LatticePathCalculator(int size)
        {
            Grid = new long[size + 1,size + 1];
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            PopulateFirstRowAndColumn();
            for (int x = 1; x < Grid.GetLength(0); x++)
            {
                for (int y = 1; y < Grid.GetLength(1); y++)
                {
                    Grid[x, y] = Grid[x - 1, y] + Grid[x, y - 1];
                }
            }
        }

        private void PopulateFirstRowAndColumn()
        {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                Grid[0, i] = 1;
                Grid[i, 0] = 1;
            }
        }

        public void Print()
        {
            for (int x = 0; x < Grid.GetLength(0); x++)
            {
                string line = "";
                for (int y = 0; y < Grid.GetLength(1); y++)
                {
                    line += Grid[x, y] + "  ";
                }
                Console.WriteLine(line);
            }
        }
    }
}