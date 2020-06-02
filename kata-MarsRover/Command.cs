using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace kata_MarsRover
{
    public class Command
    {
        
        public Command (char[] moveCommands, Position initialPosition, IGrid grid)
        {
            _moveCommands = moveCommands;
            _initialPosition = initialPosition;
            _grid = grid;
        }
        
        private readonly char[] _moveCommands;
        private readonly Position _initialPosition;
        private readonly IGrid _grid;
        
        public Position MoveRover()
        {
            var commands = _moveCommands.ToList();
            var newPosition = ExecuteCommands(commands, _initialPosition);
            return newPosition;
        }
        
        private Position ExecuteMove(char moveCommand, Position initialPosition)
        {
            IMove move = new Move(initialPosition, _grid);
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

        private Position ExecuteCommands(IList<char> commands, Position initialPosition)
        {
            if (!commands.Any()) return initialPosition;
            
            var newPosition = ExecuteMove(commands.First(), initialPosition);
            if (newPosition.HasObstacle)
            {
                Console.WriteLine("Rover cannot move further due to obstacle.");
                return initialPosition;
            }
            commands.RemoveAt(0);
            return ExecuteCommands(commands, newPosition);
           
        }
        
    }
}