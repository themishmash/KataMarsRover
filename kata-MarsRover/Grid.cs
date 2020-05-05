using System;
using System.Collections.Generic;
using MarsRoverTests;

namespace kata_MarsRover
{
    public class Grid
    {
        public int Width { get; }
        public int Length { get; }

        private Square[,] _squares; 
        public Grid(int width, int length)
        {
            Width = width;
            Length = length;
            _squares = new Square[width,length];
        }

        public Square[,] GenerateGrid()
        {
            for (int row = 0; row < Width; row++)
            {
                for (int column = 0; column < Length; column++)
                {
                    var square = new Square(row, column);
                    _squares[row, column] = square;
                }
            }

            return _squares;
        }
    }
}
