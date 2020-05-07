namespace MarsRoverTests
{
    public class Square // TODO: rename to position
    {
        public Square(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public int XCoordinate { get; }
        public int YCoordinate { get; }
    }
}

