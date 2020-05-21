using System;
using System.Collections.Generic;
using System.Reflection;

namespace kata_MarsRover
{
    public class Command
    {
        
        public Command (char moveCommand, IMove move)
        {
            _moveCommand = moveCommand;
            _move = move;
        }
        
        private readonly char _moveCommand;
        private readonly IMove _move;
        
        public Position ExecuteMove()
        {
            Position newPosition;
            switch (_moveCommand)
            {
                case 'F':
                    newPosition = _move.Forward();
                    break;
                case 'B':
                    newPosition = _move.Backward();
                    break;
                default:
                    throw new ArgumentException();
            }

            return newPosition;
        }
    }
}