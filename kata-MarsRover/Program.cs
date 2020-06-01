using System;

namespace kata_MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(3, 3);
            var coordinates = GetInitialCoordinates(grid);
            var initialDirection = GetInitialDirection();
            var commands = GetValidCommands();
            
            var initialPosition = new Position(coordinates[0], coordinates[1]) {Direction = initialDirection};
            
            var commandExecutor = new Command(commands, initialPosition, grid);
            
            var newLocation = commandExecutor.MoveRover();

            Console.WriteLine($"Your new location is: {newLocation.XCoordinate}, {newLocation.YCoordinate},{newLocation.Direction}");

        }

        private static char[] GetValidCommands()
        {
            char[] commands;
            bool isCommandValid;
            do
            {
                Console.WriteLine("Enter your move commands. F = Forwards, B = Backwards, R = Right, L = Left.");
                var inputCommands = Console.ReadLine();
                commands = InputOutput.ParseCommandToArray(inputCommands);
                isCommandValid = Validator.IsCommandValid(commands);
                if (!isCommandValid)
                {
                    Console.WriteLine("Invalid command");
                }
            } while (isCommandValid == false);
            return commands;
        }

        private static Direction GetInitialDirection()
        {
            string inputInitialDirection;
            bool isDirectionValid;
            do
            {
                Console.WriteLine("Enter your direction. N = North, S = South, E = East, W = West.");
                inputInitialDirection = Console.ReadLine();
                isDirectionValid = Validator.IsDirectionValid(inputInitialDirection);
                if (!isDirectionValid)
                {
                    Console.WriteLine("Invalid direction");
                }
            } while (isDirectionValid == false);

            var initialDirection = InputOutput.ParseStringToDirection(inputInitialDirection);
            return initialDirection;
        }

        private static int[] GetInitialCoordinates(Grid grid)
        {
            string initialCoordinates;
            bool areCoordinatesValidNumbers = false;
            int[] coordinates = new int[2];
            bool areCoordinatesWithinGridBoundaries = false;
            do
            {
                Console.WriteLine(
                    "Enter your initial position in the format X-Coordinate,Y-Coordinate");
                initialCoordinates = Console.ReadLine();
                areCoordinatesValidNumbers = Validator.AreNumbersValid(initialCoordinates);
                if (!areCoordinatesValidNumbers)
                {
                    Console.WriteLine("Invalid coordinate");
                    coordinates = InputOutput.ParseStringCoordinatesToInt(initialCoordinates);
                    areCoordinatesWithinGridBoundaries = Validator.AreCoordinatesValid(coordinates, grid);
                }
            } while (!areCoordinatesValidNumbers || !areCoordinatesWithinGridBoundaries);

            return coordinates;
        }
    }
}