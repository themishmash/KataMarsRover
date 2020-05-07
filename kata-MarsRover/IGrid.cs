using System.Collections.Generic;
using MarsRoverTests;

namespace kata_MarsRover
{
    public interface IGrid
    {
        public int Width { get; }
        
        public int Length { get; }
        List<Square> GenerateGrid();
    }
}