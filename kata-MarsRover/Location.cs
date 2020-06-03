using kata_MarsRover;

namespace kata_MarsRover
{
    public class Location
    {
        public bool HasObstacle { get; set; }
        public Location(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            HasObstacle = false;
        }

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Direction Direction { get; set; }
    }
}
