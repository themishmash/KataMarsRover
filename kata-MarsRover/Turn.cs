using System;

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
    }
}
