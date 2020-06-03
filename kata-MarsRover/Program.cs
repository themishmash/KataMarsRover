using System;

namespace kata_MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(3, 3);
            IObstacleRandomizer obstacleRandomizer = new ObstacleRandomizer();
            grid.AddObstacles(obstacleRandomizer);
            var coordinates = GetCoordinates(grid);
            var initialDirection = GetInitialDirection();
            var commands = GetValidCommands();
            
            var initialPosition = new Location(coordinates[0], coordinates[1]) {Direction = initialDirection};
            
            var commandExecutor = new Command(commands, initialPosition, grid);
            
            var newLocation = commandExecutor.MoveRover();

            Console.WriteLine($"Your new location is: {newLocation.XCoordinate}, {newLocation.YCoordinate},{newLocation.Direction}");

        }
        
        

        private static int[] GetCoordinates(IGrid grid)
        {
            int[] coordinatesNumbers; 
            bool areCoordinatesWithinGridBoundaries;
            do
            {
                coordinatesNumbers = ValidateCoordinateNumbers();
                areCoordinatesWithinGridBoundaries = ValidateCoordinateBoundaries(grid, coordinatesNumbers);
            } while (!areCoordinatesWithinGridBoundaries);

            return coordinatesNumbers;
        }
        
        private static int[] ValidateCoordinateNumbers()
        {
            bool areCoordinatesValidNumbers;
            string initialCoordinates;
            do
            {
                Console.WriteLine("Enter your initial position in the format X-Coordinate,Y-Coordinate"); //todo: wrap in output class
                initialCoordinates = Console.ReadLine(); // TODO: use an interface to enable reading from files etc, split input and output to separate classes
                areCoordinatesValidNumbers = Validator.AreNumbersValid(initialCoordinates);
                if (!areCoordinatesValidNumbers)
                {
                    Console.WriteLine("Your coordinates are not valid numbers.");
                }
            } while (!areCoordinatesValidNumbers);
    
            return InputOutput.ParseStringCoordinatesToInt(initialCoordinates);
        }

        private static bool ValidateCoordinateBoundaries(IGrid grid, int[] initialCoordinates)
        {

            var areCoordinatesWithinGridBoundaries = Validator.AreCoordinatesValid(initialCoordinates, grid);
            if (!areCoordinatesWithinGridBoundaries)
            {
                Console.WriteLine("Your coordinates are not within the boundaries.");
            }

            return areCoordinatesWithinGridBoundaries;
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

       
    }
}