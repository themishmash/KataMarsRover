using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_MarsRover
{
    public class Grid : IGrid
    {
        private readonly IList<Location> _locations;
        public int MaxXCoordinate { get; }
        public int MaxYCoordinate { get; }

        public Grid(int maxXCoordinate, int maxYCoordinate)
        {
            MaxXCoordinate = maxXCoordinate;
            MaxYCoordinate = maxYCoordinate;
            _locations = GenerateGrid();

        }

        public IList<Location> GenerateGrid()
        {
            var grid = new List<Location>();
            for (var row = 0; row <= MaxXCoordinate; row++)
            {
                for (var column = 0; column <= MaxYCoordinate; column++)
                {
                    var square = new Location(row, column);
                    grid.Add(square);
                }
            }

            return grid;
        }

        public void AddObstacles(IObstacleRandomizer obstacleRandomizer)
        {
            for (var i = 0; i < 3; i++)
            {
                var randomIndex = obstacleRandomizer.Next(0, (_locations.Count-1));
                var location = _locations[randomIndex];
                location.HasObstacle = true;
            }
            
        }

        public Location GetLocation(int xCoordinate, int yCoordinate)
        {
            return _locations.FirstOrDefault(p
                => p.XCoordinate == xCoordinate && p.YCoordinate == yCoordinate);
        }
        
        
        
        
    }
}

