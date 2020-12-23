﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler_11
{
    public class Grid
    {
        public Line[] Lines { get; set; }
        private readonly int _height;
        private readonly int _length;
        
        public Grid(string[] input)
        {
            _height = input.Length;
            _length = input[0].Split(" ").Length;
            if (!ValidateGrid(input))
                return;
            MapGrid(input);
        }

        private bool ValidateGrid(string[] input)
        {
            for (int i = 0; i < _height; i++)
            {
                if (input[i].Split(" ").Length != _length)
                    return false;
            }
            return true;
        }

        private void MapGrid(string[] input)
        {
            Lines = new Line[_height];
            for (int i = 0; i < _height; i++)
            {
                Lines[i] = new Line(input[i]);
            }
        }

        public int FindHighestProduct(int amountOfNumbers)
        {
            List<int> products = new List<int>();
            products.Add(FindHorizontalProduct(amountOfNumbers));
            products.Add(FindVerticalProduct(amountOfNumbers));
            products.Add(FindDiagonalRightDownProduct(amountOfNumbers));
            products.Add(FindDiagonalRightUpProduct(amountOfNumbers));
            return products.Max();
        }
        
        public int FindHorizontalProduct(int amountOfNumbers)
        {
            int highestProduct = 0;
            
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x <= _length - amountOfNumbers; x++)
                {
                    int product = Lines[y].Numbers[x];
                    for (int i = 1; i < amountOfNumbers; i++)
                    {
                        product *= Lines[y].Numbers[x + i];
                    }
                    if (product > highestProduct)
                        highestProduct = product;
                }
            }
            return highestProduct;
        }

        public int FindVerticalProduct(int amountOfNumbers)
        {
            int highestProduct = 0;
            
            for (int x = 0; x < _length; x++)
            {
                for (int y = 0; y <= _height - amountOfNumbers; y++)
                {
                    int product = Lines[y].Numbers[x];
                    for (int i = 1; i < amountOfNumbers; i++)
                    {
                        product *= Lines[y+i].Numbers[x];
                    }
                    if (product > highestProduct)
                        highestProduct = product;
                }
            }
            return highestProduct;
        }

        public int FindDiagonalRightDownProduct(int amountOfNumbers)
        {
            int highestProduct = 0;
            for (int y = 0; y <= _height - amountOfNumbers; y++)
            {
                for (int x = 0; x <= _length - amountOfNumbers; x++)
                {
                    int product = Lines[y].Numbers[x];
                    for (int i = 1; i < amountOfNumbers; i++)
                    {
                        product *= Lines[y + i].Numbers[x + i];
                    }
                    if (product > highestProduct)
                        highestProduct = product;
                }
            }
            return highestProduct;
        }

        public int FindDiagonalRightUpProduct(int amountOfNumbers)
        {
            int highestProduct = 0;

            for (int y = amountOfNumbers; y < _height; y++)
            {
                for (int x = 0; x <= _length - amountOfNumbers; x++)
                {
                    int product = Lines[y].Numbers[x];
                    for (int i = 1; i < amountOfNumbers; i++)
                    {
                        product *= Lines[y - i].Numbers[x + i];
                    }
                    if (product > highestProduct)
                        highestProduct = product;
                }
            }
            return highestProduct;
        }
    }
}