using System;
using System.Collections.Generic;
using MarsRoverTests;

namespace kata_MarsRover
{
    public class Grid : IGrid
    {
        private readonly IList<Position> _positions;
        public int MaxXCoordinate { get; }
        public int MaxYCoordinate { get; }
        
        
        public Grid(int maxXCoordinate, int maxYCoordinate)
        {
            MaxXCoordinate = maxXCoordinate;
            MaxYCoordinate = maxYCoordinate;
            _positions = new List<Position>();
        }

        public IList<Position> GenerateGrid()
        {
            for (int row = 0; row < MaxXCoordinate; row++)
            {
                for (int column = 0; column < MaxYCoordinate; column++)
                {
                    var square = new Position(row, column);
                    _positions.Add(square);
                }
            }

            return _positions;
        }
    }
}
