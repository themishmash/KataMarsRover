using System;
using System.Collections.Generic;
using MarsRoverTests;

namespace kata_MarsRover
{
    public class Grid
    {
        private readonly List<Square> _squares;
        private int _width { get; }
        private int _length { get; }
        
        
        public Grid(int width, int length)
        {
            _width = width;
            _length = length;
            _squares = new List<Square>();
        }

        public List<Square> GenerateGrid()
        {
            for (int row = 0; row < _width; row++)
            {
                for (int column = 0; column < _length; column++)
                {
                    var square = new Square(row, column);
                    _squares.Add(square);
                }
            }

            return _squares;
        }
    }
}
