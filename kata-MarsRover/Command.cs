using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace kata_MarsRover
{
    public class Command
    {
        
        public Command (char[] moveCommands, Location initialLocation, IGrid grid)
        {
            _moveCommands = moveCommands;
            _initialLocation = initialLocation;
            _grid = grid;
        }
        
        private readonly char[] _moveCommands;
        private readonly Location _initialLocation;
        private readonly IGrid _grid;
        
        public Location MoveRover()
        {
            var commands = _moveCommands.ToList();
            var newPosition = ExecuteCommands(commands, _initialLocation);
            return newPosition;
        }
        
        private Location ExecuteMove(char moveCommand, Location initialLocation)
        {
            IMove move = new Move(initialLocation, _grid);
            var newPosition = moveCommand switch
            {
                'F' => move.Forward(),
                'B' => move.Backward(),
                'R' => move.Right(),
                'L' => move.Left(),
                _ => throw new ArgumentException()
            };
            
            return newPosition;
        }

        private Location ExecuteCommands(IList<char> commands, Location initialLocation)
        {
            if (!commands.Any()) return initialLocation;
            
            var newPosition = ExecuteMove(commands.First(), initialLocation);
            if (newPosition.HasObstacle)
            {
                Console.WriteLine("Rover cannot move further due to obstacle.");
                return initialLocation;
            }
            commands.RemoveAt(0);
            return ExecuteCommands(commands, newPosition);
           
        }
        
    }
}