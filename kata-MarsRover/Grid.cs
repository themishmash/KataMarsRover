using System;
using System.Collections.Generic;

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
            _positions = GenerateGrid();

        }

        public IList<Position> GenerateGrid()
        {
            var grid = new List<Position>();
            for (var row = 0; row <= MaxXCoordinate; row++)
            {
                for (var column = 0; column <= MaxYCoordinate; column++)
                {
                    var square = new Position(row, column);
                    grid.Add(square);
                }
            }

            return grid;
        }

        public void AddObstacles()
        {
            for (var i = 0; i < 3; i++)
            {
                var random = new Random();
                var randomIndex = random.Next(0, (_positions.Count-1));
                var obstacle = _positions[randomIndex];
                obstacle.HasObstacle = true;
            }
            
        }
    }
}

