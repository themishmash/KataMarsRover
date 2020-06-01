using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_MarsRover
{
    public static class InputOutput
    {
        public static char[] ParseCommandToArray(string commandString)
        {
            var commandArray = commandString.ToCharArray();
            return commandArray;
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