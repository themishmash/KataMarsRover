using System;
using MarsRoverTests;

namespace kata_MarsRover
{
    public class Turn
    {
        public Turn(Position initialPosition)
        {
            _initialPosition = initialPosition;
        }
        
        private readonly Position _initialPosition;
        public Position Right()
        {
            Direction newDirection;
            switch (_initialPosition.Direction)
            {
                case Direction.North:
                    newDirection = Direction.East;
                    break;
                case Direction.East:
                    newDirection = Direction.South;
                    break;
                case Direction.South:
                    newDirection = Direction.West;
                    break;
                case Direction.West:
                    newDirection = Direction.North;
                    break;
                default: throw new ArgumentException();
            }
            return new Position(_initialPosition.XCoordinate, _initialPosition.YCoordinate) {Direction = newDirection};
        }

        public Position Left()
        {
            Direction newDirection;
            switch (_initialPosition.Direction)
            {
                case Direction.North:
                    newDirection = Direction.West;
                    break;
                case Direction.East:
                    newDirection = Direction.North;
                    break;
                case Direction.South:
                    newDirection = Direction.East;
                    break;
                case Direction.West:
                    newDirection = Direction.South;
                    break;
                default: throw new ArgumentException();
                
            }
            return new Position(_initialPosition.XCoordinate, _initialPosition.YCoordinate) {Direction = newDirection};
        }
    }
}