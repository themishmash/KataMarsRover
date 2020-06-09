using kata_MarsRover;
using Xunit; 
using Moq;


namespace MarsRoverTests
{
    public class CommandShould
    {
        
        [Theory]
        [InlineData(new char[]{'F','B','R','L'}, 1, 1, Direction.North)]
        [InlineData(new char[]{'F','F','L','L'}, 1, 3, Direction.South)]
        [InlineData(new char[]{'F','L','F','F'}, 3, 2, Direction.West)]
        public void ExecuteCommandSeries(char[] commands, int expectedXCCoordinate, int expectedYCoordinate, Direction expectedDirection)
        {
            var sut = new Command(commands, new Location(1, 1){Direction = Direction.North}, new Grid(3, 3));
            var actual = sut.MoveRover();
            
            var expected = new Location(expectedXCCoordinate, expectedYCoordinate) {Direction = expectedDirection};
            Assert.Equal(expected.XCoordinate, actual.XCoordinate);
            Assert.Equal(expected.YCoordinate, actual.YCoordinate);
            Assert.Equal(expected.Direction, actual.Direction);
        }
        
        [Theory]
        [InlineData(new char[]{'F','F','F','F'}, 0, 2, Direction.North)]
        public void StopExecutingIfObstacleEncountered(char[] commands, int expectedXCCoordinate, int expectedYCoordinate, Direction expectedDirection)
        {
            var mockObstacleRandomizer = new Mock<IObstacleRandomizer>();
            var grid = new Grid(3, 3);
            var sut = new Command(commands, new Location(0, 0){Direction = Direction.North}, grid);
            mockObstacleRandomizer.SetupSequence(r => r.Next(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(2) //(0,2)
                .Returns(5) //(1,1)
                .Returns(7);//(1,3)
            grid.AddObstacles(mockObstacleRandomizer.Object);
            
            var actual = sut.MoveRover();
               
            Assert.Equal(0, actual.XCoordinate);
            Assert.Equal(2, actual.YCoordinate);
            Assert.Equal(Direction.North, actual.Direction);

        }

    }
}