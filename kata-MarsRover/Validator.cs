using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_MarsRover
{
    public static class Validator
    {
        public static bool AreNumbersValid(string initialCoordinates)
        {
            var elements = initialCoordinates.Split(",", StringSplitOptions.RemoveEmptyEntries);
            var isXCoordinateValid = int.TryParse(elements[0], out var xCoordinate);
            var isYCoordinateValid = int.TryParse(elements[0], out var yCoordinate);
            return isXCoordinateValid && isYCoordinateValid;
        }
        
        public static bool IsCommandValid(IEnumerable<char> commandArray)
        {
            var validCommands = new char[]{'F','B','L','R'};
            return commandArray.All(c => validCommands.Contains(c));
        }
        
        public static bool IsDirectionValid(string direction)
        {
            var directionUpper = direction.ToUpper();
            var validDirections = new string[]{"N","E","S","W"};
            return validDirections.Contains(directionUpper);
        }
        
        public static bool AreCoordinatesValid(int[] coordinates, IGrid grid)
        {
            return (coordinates[0] <= grid.MaxXCoordinate) && (coordinates[1] <= grid.MaxYCoordinate);
        }
    }
}