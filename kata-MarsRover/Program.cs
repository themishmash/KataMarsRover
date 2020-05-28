using System;

namespace kata_MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialCoordinates;
            bool isCoordinatesValid;
            do
            {
                Console.WriteLine(
                    "Welcome to Mars Rover. Enter your initial position in the format X-Coordinate,Y-Coordinate");
                initialCoordinates = Console.ReadLine();
                isCoordinatesValid = InputOutput.IsCoordinateValid(initialCoordinates);
                if (!isCoordinatesValid)
                {
                    Console.WriteLine( "Invalid coordinate");
                }
            } while (isCoordinatesValid == false);
            
            
            var coordinates = InputOutput.ParseStringCoordinatesToInt(initialCoordinates);
            string inputInitialDirection
                ;
            bool isDirectionValid;
            do
            {
                Console.WriteLine("Enter your direction. N = North, S = South, E = East, W = West.");
                inputInitialDirection = Console.ReadLine();
                isDirectionValid = InputOutput.IsDirectionValid(inputInitialDirection);
                if (!isDirectionValid)
                {
                    Console.WriteLine( "Invalid direction");
                }
            } while (isDirectionValid == false);

            var initialDirection = InputOutput.ParseStringToDirection(inputInitialDirection);

            char[] commands;
            bool isCommandValid;
            do
            {
                Console.WriteLine("Enter your move commands. F = Forwards, B = Backwards, R = Right, L = Left.");
                var inputCommands = Console.ReadLine();
                commands = InputOutput.ParseCommandToArray(inputCommands);
                isCommandValid = InputOutput.IsCommandValid(commands);
                if (!isCommandValid)
                {
                    Console.WriteLine("Invalid command");
                }
            } while (isCommandValid == false);
            
            
            var initialPosition = new Position(coordinates[0], coordinates[1]);
            var grid = new Grid(3, 3);
            var commandExecutor = new Command(commands, initialPosition, grid);
            var newLocation = commandExecutor.MoveRover();

            Console.WriteLine($"Your new location is: {newLocation.XCoordinate}, {newLocation.YCoordinate},{newLocation.Direction}");

        }

        
    }
}