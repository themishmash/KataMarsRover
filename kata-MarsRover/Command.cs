using System;
using System.Collections.Generic;
using System.Reflection;

namespace kata_MarsRover
{
    public class Command
    {
        
        public Command (char moveCommand, Position initialPosition, Grid grid)
        {
            _moveCommand = moveCommand;
            _initialPosition = initialPosition;
            _grid = grid;
        }
        
        
        private readonly char _moveCommand;
        private readonly Position _initialPosition;
        private readonly Grid _grid;


        public Position ExecuteMove()
        {
            Position newPosition;
            switch (_moveCommand)
            {
                case 'F':
                    newPosition = Move.Forward(_initialPosition, _grid);
                    break;
                default:
                    throw new ArgumentException();
            }

            return newPosition;
        }
    }
}