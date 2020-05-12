using System;
using System.Diagnostics;
using MarsRoverTests;

namespace kata_MarsRover
{
    public class Move
    {
        private Position _initialPosition;
        private  Direction _initialDirection;
        private readonly IGrid _grid;

        public Move(Position initialPosition, Direction initialDirection, IGrid grid)
        {
            _initialPosition = initialPosition;
            _initialDirection = initialDirection;
            _grid = grid;
        }
        public Position Forward()
        {
            int newXCoordinate;
            int newYCoordinate;
            switch (_initialDirection)
            {
                case Direction.N: //TODO: add max boundaries for other directions too, consider refactoring afterwards to a generic function
                    newXCoordinate = _initialPosition.XCoordinate;
                    newYCoordinate = _initialPosition.YCoordinate + 1;

                    break;
                case Direction.E:
                    newXCoordinate = _initialPosition.XCoordinate + 1;
                    newYCoordinate = _initialPosition.YCoordinate;
                    break;
                case Direction.S:
                    newXCoordinate = _initialPosition.XCoordinate;
                    newYCoordinate = _initialPosition.YCoordinate - 1; //TODO: consider changing this to a method
                    break;
                case Direction.W:
                    newXCoordinate = _initialPosition.XCoordinate - 1;
                    newYCoordinate = _initialPosition.YCoordinate;
                    break;
                default:
                    throw new ArgumentException();
            }
            
            return CheckBoundaries(new Position(newXCoordinate, newYCoordinate));
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