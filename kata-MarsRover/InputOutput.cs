using System;

namespace kata_MarsRover
{
    public static class InputOutput
    {
        public static Position CreatePosition(string initialPosition)
        {
            var elements = initialPosition.Split(",", StringSplitOptions.RemoveEmptyEntries);
            var xCoordinate = ParseStringToInt(elements[0]);
            var yCoordinate = ParseStringToInt(elements[1]);
            var direction = ParseStringToDirection(elements[2]);
            return new Position(xCoordinate,yCoordinate){Direction = direction};
        }
        
        private static int ParseStringToInt(string number)
        {
            var isNumberValid = int.TryParse(number, out var coordinate);
            if (!isNumberValid)
            {
                throw new ArgumentException("Not a valid number");
            }
            return coordinate;
        }

        private static Direction ParseStringToDirection(string direction)
        {
            var directionUpper = direction.ToUpper();
            var parsedDirection = directionUpper switch
            {
                "N" => Direction.North,
                "E" => Direction.East,
                "S" => Direction.South,
                "W" => Direction.West,
                _ => throw new ApplicationException()
            };
            return parsedDirection;
        }

       
    }
}