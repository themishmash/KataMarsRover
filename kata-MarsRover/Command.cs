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
        private Position _initialPosition;
        private readonly IGrid _grid;


        private Position ExecuteMove(char moveCommand, IMove move)
        {
            Position newPosition;
            switch (moveCommand)
            {
                case 'F':
                    newPosition = move.Forward();
                    break;
                case 'B':
                    newPosition = move.Backward();
                    break;
                case 'R':
                    newPosition = move.Right();
                    break;
                case 'L':
                    newPosition = move.Left();
                    break;
                default:
                    throw new ArgumentException();
            }

            return newPosition;
        }

        public Position ExecuteCommands(List<char> commands)
        {
            Position newPosition = _initialPosition;
            if (!commands.Any())
            {
                return newPosition;
            }
            IMove move = new Move(newPosition, _grid);

            newPosition = ExecuteMove(commands.First(), move);
            commands.RemoveAt(0);
            return ExecuteCommands(commands);
        }

        public Position MoveRover()
        {
            var commands = _moveCommands.ToList();
            var newPosition = ExecuteCommands(commands);
            return newPosition;
        }
    }
}