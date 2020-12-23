﻿using System;

namespace Euler_18
{
    public class PathSumCalculator
    {
        private int[,] _grid;
        private int[,] _sumGrid;

        public PathSumCalculator(string[] input)
        {
            ParseInput(input);
            CalculateSumGrid();
        }
        
        private void ParseInput(string[] input)
        {
            _grid = new int[input.Length, input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string[] numbers = input[i].Split(" ");
                for (int index = 0; index < numbers.Length; index++)
                {
                    _grid[index, i] = int.Parse(numbers[index]);
                }
            }
        }

        private void CalculateSumGrid()
        {
            _sumGrid = new int[_grid.GetLength(0),_grid.GetLength(1)];
            _sumGrid[0, 0] = _grid[0, 0];
            int count = 2;
            for (int y = 1; y < _grid.GetLength(1); y++)
            {
                for (int x = 0; x < count; x++)
                {
                    if (x == 0)
                        _sumGrid[x, y] = _grid[x, y] + _sumGrid[x, y - 1];
                    else if (x == count - 1)
                        _sumGrid[x, y] = _grid[x, y] + _sumGrid[x - 1, y - 1];
                    else if (_sumGrid[x, y - 1] >= _sumGrid[x - 1, y - 1])
                        _sumGrid[x, y] = _grid[x, y] + _sumGrid[x, y - 1];
                    else
                        _sumGrid[x, y] = _grid[x, y] + _sumGrid[x - 1, y - 1];
                }
                count++;
            }
        }
        
        public int GetHighestSum()
        {
            int answer = 0;
            int y = _sumGrid.GetLength(0) - 1;
            for (int x = 0; x < _sumGrid.GetLength(0); x++)
            {
                if (_sumGrid[x, y] > answer)
                    answer = _sumGrid[x, y];
            }
            return answer;
        }
        
        public string GetPrintableSumGrid()
        {
            return PrintGrid(_sumGrid);
        }
        
        public string GetPrintableInput()
        {
            return PrintGrid(_grid);
        }
        
        private string PrintGrid(int[,] grid)
        {
            string gridAsString = "";
            int count = 1;
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                string s = "";
                for (int x = 0; x < count; x++)
                {
                    s += grid[x, y] + " "; 
                }
                gridAsString += s + "\n";
                count++;
            }
            return gridAsString;
        }
    }
}