using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_MarsRover
{
    public static class InputOutput
    {
        public static bool IsCoordinateValid(string initialCoordinates)
        {
            var elements = initialCoordinates.Split(",", StringSplitOptions.RemoveEmptyEntries);
            var isXCoordinateValid = int.TryParse(elements[0], out var xCoordinate);
            var isYCoordinateValid = int.TryParse(elements[0], out var yCoordinate);
            return isXCoordinateValid && isYCoordinateValid;
        }
        
        public static char[] ParseCommandToArray(string commandString)
        {
            var commandArray = commandString.ToCharArray();
            //TODO: use select method to convert each char to upper and to toarray
            return commandArray;
        }
        
        public static bool IsCommandValid(IEnumerable<char> commandArray)
        {
            var validCommands = new char[]{'F','B','L','R'};
            return commandArray.All(c => validCommands.Contains(c));
        }
        
        public static bool IsDirectionValid(string direction)
        {
            //TODO: convert direction to upper
            var validDirections = new string[]{"N","E","S","W"};
            return validDirections.Contains(direction);
        }
        
        public static int[] ParseStringCoordinatesToInt(string number)
        {
            var stringCoordinates = number.Split(",", StringSplitOptions.RemoveEmptyEntries);
            return stringCoordinates.Select(int.Parse).ToArray();
        }

        public static Direction ParseStringToDirection(string direction)
        {
            var directionUpper = direction.ToUpper();
            var parsedDirection = directionUpper switch
            {
                "N" => Direction.North,
                "E" => Direction.East,
                "S" => Direction.South,
                "W" => Direction.West,
                _ => throw new ArgumentException()
            };
            return parsedDirection;
        }
        
        

    }
}