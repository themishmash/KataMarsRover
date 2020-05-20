using System;
using System.Collections.Generic;
using System.Reflection;

namespace kata_MarsRover
{
    public static class Command
    {
        public static Position Move(char moveCommand)
        {
            throw new System.NotImplementedException();
        }


        private static Dictionary<char, Func<char, Position>> _moveCommands =
            new Dictionary<char, Func<char, Position>>
            {
                {'F', kata_MarsRover.Move.Forward()}
            };
        
        
        
        
        
        
    }
}