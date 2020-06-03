using System.Collections.Generic;


namespace kata_MarsRover
{
    public interface IGrid
    {
        public int MaxXCoordinate { get; }
        
        public int MaxYCoordinate { get; }
        IList<Location> GenerateGrid();
    }
}