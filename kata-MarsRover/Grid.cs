using System;
using System.Collections.Generic;
using MarsRoverTests;

namespace kata_MarsRover
{
    public class Grid
    {
        private readonly List<Square> _squares;
        public int Width { get; }
        public int Length { get; }
        
        
        public Grid(int width, int length)
        {
            Width = width;
            Length = length;
            _squares = new List<Square>();
        }

        public List<Square> GenerateGrid()
        {
            for (int row = 0; row < Width; row++)
            {
                for (int column = 0; column < Length; column++)
                {
                    var square = new Square(row, column);
                    _squares.Add(square);
                }
            }

            return _squares;
        }
    }
}
