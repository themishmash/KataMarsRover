using System;
using System.Diagnostics;


namespace kata_MarsRover
{
    public class Move
    {
        // private readonly Position initialPosition;
        // private readonly IGrid _grid;

        // public Move(Position initialPosition, IGrid grid)
        // {
        //     initialPosition = initialPosition;
        //     _grid = grid;
      //  }
        public static Position Forward(Position initialPosition, IGrid grid)
        {
            Position newPosition = initialPosition.Direction switch
            {
                Direction.North => IncrementYCoordinate(initialPosition),
                Direction.East => IncrementXCoordinate(initialPosition),
                Direction.South => DecrementYCoordinate(initialPosition),
                Direction.West => DecrementXCoordinate(initialPosition),
                _ => throw new ArgumentException()
            };

            return CheckBoundaries(newPosition, grid);
        }
        
        public static Position Backward(Position initialPosition, IGrid grid)
        {
            var newPosition = initialPosition.Direction switch
            {
                Direction.North => DecrementYCoordinate(initialPosition),
                Direction.East => DecrementXCoordinate(initialPosition),
                Direction.South => IncrementYCoordinate(initialPosition),
                Direction.West => IncrementXCoordinate(initialPosition),
                _ => throw new ArgumentException()
            };
            return CheckBoundaries(newPosition, grid);
        }

        private static Position DecrementXCoordinate(Position initialPosition)
        {
            var newXCoordinate = DecrementCoordinateBy1(initialPosition.XCoordinate);
            var newYCoordinate = initialPosition.YCoordinate;
            return new Position(newXCoordinate, newYCoordinate) {Direction = initialPosition.Direction};
        }

        private static Position DecrementYCoordinate(Position initialPosition)
        {
            var newXCoordinate = initialPosition.XCoordinate;
            var newYCoordinate = DecrementCoordinateBy1(initialPosition.YCoordinate);
            return new Position(newXCoordinate, newYCoordinate) {Direction = initialPosition.Direction};
        }

        private static Position IncrementXCoordinate(Position initialPosition)
        {
            
            var newXCoordinate = IncrementCoordinateBy1(initialPosition.XCoordinate);
            var newYCoordinate = initialPosition.YCoordinate;
            return new Position(newXCoordinate, newYCoordinate) {Direction = initialPosition.Direction};
        }

        private static Position IncrementYCoordinate(Position initialPosition)
        {
            var newXCoordinate = initialPosition.XCoordinate;
            var newYCoordinate = IncrementCoordinateBy1(initialPosition.YCoordinate);
            return new Position(newXCoordinate, newYCoordinate) {Direction = initialPosition.Direction};
        }

        private static int DecrementCoordinateBy1(int coordinate)
        {
            return coordinate - 1;
        }
        
        private static int IncrementCoordinateBy1(int coordinate)
        {
            return coordinate + 1;
        }

        private static Position CheckBoundaries(Position position, IGrid grid)
        {
            position = CheckAndResetLowerBoundaries(position, grid);
            position = CheckAndResetUpperBoundaries(position, grid);
            return position;
        }
        private static Position CheckAndResetLowerBoundaries(Position position, IGrid grid)
        {
            if (position.XCoordinate < 0)
            {
                position.XCoordinate = grid.MaxXCoordinate;
            }
            if (position.YCoordinate < 0)
            {
                position.YCoordinate = grid.MaxYCoordinate;
            }

            return position;
        }

        private static Position CheckAndResetUpperBoundaries(Position position, IGrid grid)
        {
            if (position.XCoordinate > grid.MaxXCoordinate )
            {
               position.XCoordinate = 0;
            }

            if (position.YCoordinate > grid.MaxYCoordinate)
            {
                position.YCoordinate = 0;
            }

            return position;
        }
    }
}
