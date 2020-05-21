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
            _turn = new Turn(initialPosition); //TODO make Turn class non-static
            _move = new Move(initialPosition, grid);
          
        }
        
        private readonly char _moveCommand;
        private readonly Position _initialPosition;
        private readonly Grid _grid;
        private readonly IMove _move;
        private readonly ITurn _turn;
        
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