using System;

namespace kata_MarsRover
{
    public static class Turn
    {
        public static Position Right(Position initialPosition)
        {
            var newDirection = initialPosition.Direction switch
            {
                Direction.North => Direction.East,
                Direction.East => Direction.South,
                Direction.South => Direction.West,
                Direction.West => Direction.North,
                _ => throw new ArgumentException()
            };
            return new Position(initialPosition.XCoordinate, initialPosition.YCoordinate) {Direction = newDirection};
        }

        public static Position Left(Position initialPosition)
        {
            var newDirection = initialPosition.Direction switch
            {
                Direction.North => Direction.West,
                Direction.East => Direction.North,
                Direction.South => Direction.East,
                Direction.West => Direction.South,
                _ => throw new ArgumentException()
            };
            return new Position(initialPosition.XCoordinate, initialPosition.YCoordinate) {Direction = newDirection};
        }
    }
}
