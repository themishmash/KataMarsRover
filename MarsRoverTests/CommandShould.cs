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
            var sut = new Command(commands, new Position(1, 1){Direction = Direction.North}, new Grid(3, 3));
            var actual = sut.MoveRover();
            
            var expected = new Position(expectedXCCoordinate, expectedYCoordinate) {Direction = expectedDirection};
            Assert.Equal(expected.XCoordinate, actual.XCoordinate);
            Assert.Equal(expected.YCoordinate, actual.YCoordinate);
            Assert.Equal(expected.Direction, actual.Direction);
        }

    }
}