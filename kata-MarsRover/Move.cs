using System;
using System.Diagnostics;


namespace kata_MarsRover
{
    public class Move : IMove
    {
        public Move(Location initialLocation, IGrid grid)
        {
            _initialLocation = initialLocation;
            _grid = grid;
        }
        
        private readonly Location _initialLocation;
        private readonly IGrid _grid;
        public Location Forward()
        {
            var newPosition = _initialLocation.Direction switch
            {
                Direction.North => IncrementYCoordinate(),
                Direction.East => IncrementXCoordinate(),
                Direction.South => DecrementYCoordinate(),
                Direction.West => DecrementXCoordinate(),
                _ => throw new ArgumentException()
            };

            return CheckBoundaries(newPosition);
        }
        
        public Location Backward()
        {
            var newPosition = _initialLocation.Direction switch
            {
                Direction.North => DecrementYCoordinate(),
                Direction.East => DecrementXCoordinate(),
                Direction.South => IncrementYCoordinate(),
                Direction.West => IncrementXCoordinate(),
                _ => throw new ArgumentException()
            };
            return CheckBoundaries(newPosition);
        }
        
        public Location Right()
        {
            var newDirection = _initialLocation.Direction switch
            {
                Direction.North => Direction.East,
                Direction.East => Direction.South,
                Direction.South => Direction.West,
                Direction.West => Direction.North,
                _ => throw new ArgumentException()
            };
            return new Location(_initialLocation.XCoordinate, _initialLocation.YCoordinate) {Direction = 
            newDirection, HasObstacle = _initialLocation.HasObstacle};
        }

        public Location Left()
        {
            var newDirection = _initialLocation.Direction switch
            {
                Direction.North => Direction.West,
                Direction.East => Direction.North,
                Direction.South => Direction.East,
                Direction.West => Direction.South,
                _ => throw new ArgumentException()
            };
            return new Location(_initialLocation.XCoordinate, _initialLocation.YCoordinate) {Direction = newDirection, HasObstacle = _initialLocation.HasObstacle};
        }
        
        private Location DecrementXCoordinate()
        {
            var newXCoordinate = DecrementCoordinateBy1(_initialLocation.XCoordinate);
            var newYCoordinate = _initialLocation.YCoordinate;
            return new Location(newXCoordinate, newYCoordinate) {Direction = _initialLocation.Direction, HasObstacle = _initialLocation.HasObstacle};
        }

        private Location DecrementYCoordinate()
        {
            var newXCoordinate = _initialLocation.XCoordinate;
            var newYCoordinate = DecrementCoordinateBy1(_initialLocation.YCoordinate);
            return new Location(newXCoordinate, newYCoordinate) {Direction = _initialLocation.Direction, HasObstacle = _initialLocation.HasObstacle};
        }

        private Location IncrementXCoordinate()
        {
            
            var newXCoordinate = IncrementCoordinateBy1(_initialLocation.XCoordinate);
            var newYCoordinate = _initialLocation.YCoordinate;
            return new Location(newXCoordinate, newYCoordinate) {Direction = _initialLocation.Direction, HasObstacle = _initialLocation.HasObstacle};
        }

        private Location IncrementYCoordinate()
        {
            var newXCoordinate = _initialLocation.XCoordinate;
            var newYCoordinate = IncrementCoordinateBy1(_initialLocation.YCoordinate);
            return new Location(newXCoordinate, newYCoordinate) {Direction = _initialLocation.Direction, HasObstacle = _initialLocation.HasObstacle};
        }

        private static int DecrementCoordinateBy1(int coordinate)
        {
            return coordinate - 1;
        }
        
        private static int IncrementCoordinateBy1(int coordinate)
        {
            return coordinate + 1;
        }

        private Location CheckBoundaries(Location location)
        {
            location = ResetLowerBoundaries(location);
            location = ResetUpperBoundaries(location);
            return location;
        }
        private Location ResetLowerBoundaries(Location location)
        {
            if (location.XCoordinate < 0)
            {
                location.XCoordinate = _grid.MaxXCoordinate;
            }
            if (location.YCoordinate < 0)
            {
                location.YCoordinate = _grid.MaxYCoordinate;
            }

            return location;
        }

        private Location ResetUpperBoundaries(Location location)
        {
            if (location.XCoordinate > _grid.MaxXCoordinate )
            {
               location.XCoordinate = 0;
            }

            if (location.YCoordinate > _grid.MaxYCoordinate)
            {
                location.YCoordinate = 0;
            }

            return location;
        }
    }
}
