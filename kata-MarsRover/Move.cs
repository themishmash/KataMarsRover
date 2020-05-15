using System;
using System.Diagnostics;
using MarsRoverTests;

namespace kata_MarsRover
{
    public class Move
    {
        private Position _initialPosition;
       // private  Direction _initialDirection;
        private readonly IGrid _grid;

        public Move(Position initialPosition, IGrid grid)
        {
            _initialPosition = initialPosition;
            _grid = grid;
        }
        public Position Forward()
        {
            int newXCoordinate;
            int newYCoordinate;
            Position newPosition;
            switch (_initialPosition.Direction)
            {
                   
                case Direction.N:
                    newPosition = IncrementYCoordinate();

                    break;
                case Direction.E:
                    newPosition = IncrementXCoordinate();
                    break;
                case Direction.S:
                    newPosition= DecrementYCoordinate();
                    break;
                case Direction.W:
                    newPosition = DecrementXCoordinate();
                    break;
                default:
                    throw new ArgumentException();
            }

            newPosition.Direction = _initialPosition.Direction;

            return CheckBoundaries(newPosition);
        }
        
        public Position Backward()
        {
            int newXCoordinate;
            int newYCoordinate;
            Position newPosition;
            switch (_initialPosition.Direction)
            {
                case Direction.N:
                    newPosition = DecrementYCoordinate();
                    break;
                case Direction.E:
                    newPosition = DecrementXCoordinate();
                    break;
                case Direction.S:
                    newPosition = IncrementYCoordinate();
                    break;
                case Direction.W:
                    newPosition = IncrementXCoordinate();
                    break;
                default:
                    throw new ArgumentException();
            }

            newPosition.Direction = _initialPosition.Direction;

            return CheckBoundaries(newPosition);

        }

        private Position DecrementXCoordinate()
        {
            var newXCoordinate = DecrementCoordinateBy1(_initialPosition.XCoordinate);
            var newYCoordinate = _initialPosition.YCoordinate;
            return new Position(newXCoordinate, newYCoordinate);
        }

        private Position DecrementYCoordinate()
        {
            var newXCoordinate = _initialPosition.XCoordinate;
            var newYCoordinate = DecrementCoordinateBy1(_initialPosition.YCoordinate);
            return new Position(newXCoordinate, newYCoordinate);
        }

        private Position IncrementXCoordinate()
        {
            
            var newXCoordinate = IncrementCoordinateBy1(_initialPosition.XCoordinate);
            var newYCoordinate = _initialPosition.YCoordinate;
            return new Position(newXCoordinate, newYCoordinate);
        }

        private Position IncrementYCoordinate()
        {
            var newXCoordinate = _initialPosition.XCoordinate;
            var newYCoordinate = IncrementCoordinateBy1(_initialPosition.YCoordinate);
            return new Position(newXCoordinate, newYCoordinate);
        }

        private static int DecrementCoordinateBy1(int coordinate)
        {
            return coordinate - 1;
        }
        
        private int IncrementCoordinateBy1(int coordinate)
        {
            return coordinate + 1;
        }

        private Position CheckBoundaries(Position position)
        {
            position = CheckAndResetLowerBoundaries(position);
            position = CheckAndResetUpperBoundaries(position);
            return position;
        }
        private Position CheckAndResetLowerBoundaries(Position position)
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

        private Position CheckAndResetUpperBoundaries(Position position)
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
//TODO: method to check if rover can move or not (i.e. has boundaries been exceeded?)