using System;
using System.Diagnostics;


namespace kata_MarsRover
{
    public class Move : IMove
    {

        public Move(Position initialPosition, IGrid grid)
        {
            _initialPosition = initialPosition;
            _grid = grid;
        }
        private readonly Position _initialPosition;
        private readonly IGrid _grid;
        public Position Forward()
        {
            var newPosition = _initialPosition.Direction switch
            {
                Direction.North => IncrementYCoordinate(),
                Direction.East => IncrementXCoordinate(),
                Direction.South => DecrementYCoordinate(),
                Direction.West => DecrementXCoordinate(),
                _ => throw new ArgumentException()
            };

            return CheckBoundaries(newPosition);
        }
        
        public Position Backward()
        {
            var newPosition = _initialPosition.Direction switch
            {
                Direction.North => DecrementYCoordinate(),
                Direction.East => DecrementXCoordinate(),
                Direction.South => IncrementYCoordinate(),
                Direction.West => IncrementXCoordinate(),
                _ => throw new ArgumentException()
            };
            return CheckBoundaries(newPosition);
        }
        
        public Position Right()
        {
            var newDirection = _initialPosition.Direction switch
            {
                Direction.North => Direction.East,
                Direction.East => Direction.South,
                Direction.South => Direction.West,
                Direction.West => Direction.North,
                _ => throw new ArgumentException()
            };
            return new Position(_initialPosition.XCoordinate, _initialPosition.YCoordinate) {Direction = newDirection};
        }

        public Position Left()
        {
            var newDirection = _initialPosition.Direction switch
            {
                Direction.North => Direction.West,
                Direction.East => Direction.North,
                Direction.South => Direction.East,
                Direction.West => Direction.South,
                _ => throw new ArgumentException()
            };
            return new Position(_initialPosition.XCoordinate, _initialPosition.YCoordinate) {Direction = newDirection};
        }
        
        private Position DecrementXCoordinate()
        {
            var newXCoordinate = DecrementCoordinateBy1(_initialPosition.XCoordinate);
            var newYCoordinate = _initialPosition.YCoordinate;
            return new Position(newXCoordinate, newYCoordinate) {Direction = _initialPosition.Direction};
        }

        private Position DecrementYCoordinate()
        {
            var newXCoordinate = _initialPosition.XCoordinate;
            var newYCoordinate = DecrementCoordinateBy1(_initialPosition.YCoordinate);
            return new Position(newXCoordinate, newYCoordinate) {Direction = _initialPosition.Direction};
        }

        private Position IncrementXCoordinate()
        {
            
            var newXCoordinate = IncrementCoordinateBy1(_initialPosition.XCoordinate);
            var newYCoordinate = _initialPosition.YCoordinate;
            return new Position(newXCoordinate, newYCoordinate) {Direction = _initialPosition.Direction};
        }

        private Position IncrementYCoordinate()
        {
            var newXCoordinate = _initialPosition.XCoordinate;
            var newYCoordinate = IncrementCoordinateBy1(_initialPosition.YCoordinate);
            return new Position(newXCoordinate, newYCoordinate) {Direction = _initialPosition.Direction};
        }

        private static int DecrementCoordinateBy1(int coordinate)
        {
            return coordinate - 1;
        }
        
        private static int IncrementCoordinateBy1(int coordinate)
        {
            return coordinate + 1;
        }

        private Position CheckBoundaries(Position position)
        {
            position = ResetLowerBoundaries(position);
            position = ResetUpperBoundaries(position);
            return position;
        }
        private Position ResetLowerBoundaries(Position position)
        {
            if (position.XCoordinate < 0)
            {
                position.XCoordinate = _grid.MaxXCoordinate;
            }
            if (position.YCoordinate < 0)
            {
                position.YCoordinate = _grid.MaxYCoordinate;
            }

            return position;
        }

        private Position ResetUpperBoundaries(Position position)
        {
            if (position.XCoordinate > _grid.MaxXCoordinate )
            {
               position.XCoordinate = 0;
            }

            if (position.YCoordinate > _grid.MaxYCoordinate)
            {
                position.YCoordinate = 0;
            }

            return position;
        }
    }
}
