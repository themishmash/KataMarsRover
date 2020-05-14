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
            switch (_initialPosition.Direction)
            {
                case Direction.N:
                    newXCoordinate = _initialPosition.XCoordinate;
                    newYCoordinate = IncrementCoordinateBy1(_initialPosition.YCoordinate);

                    break;
                case Direction.E:
                    newXCoordinate = IncrementCoordinateBy1(_initialPosition.XCoordinate);
                    newYCoordinate = _initialPosition.YCoordinate;
                    break;
                case Direction.S:
                    newXCoordinate = _initialPosition.XCoordinate;
                    newYCoordinate = DecrementCoordinateBy1(_initialPosition.YCoordinate);
                    break;
                case Direction.W:
                    newXCoordinate = DecrementCoordinateBy1(_initialPosition.XCoordinate);
                    newYCoordinate = _initialPosition.YCoordinate;
                    break;
                default:
                    throw new ArgumentException();
            }

            return CheckBoundaries(new Position(newXCoordinate, newYCoordinate) {Direction = _initialPosition.Direction});
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