using System;
using System.Diagnostics;
using MarsRoverTests;

namespace kata_MarsRover
{
    public class Move
    {
        private Square _initialPosition;
        private  Direction _initialDirection;
        private readonly IGrid _grid;

        public Move(Square initialPosition, Direction initialDirection, IGrid grid)
        {
            _initialPosition = initialPosition;
            _initialDirection = initialDirection;
            _grid = grid;
        }
        public Square Forward()
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
                    if (newYCoordinate < 0)
                    {
                        newYCoordinate += _grid.Width;
                    }
                    break;
                default:
                    throw new ArgumentException();
            }
            return new Square(newXCoordinate, newYCoordinate);
        }
    }
}
//TODO: method to check if rover can move or not (i.e. has boundaries been exceeded?)