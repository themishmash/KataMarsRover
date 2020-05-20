using kata_MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class InputOutputShould
    {
        [Fact]
        public void ParseStringToPositionObject()
        {
            const string testInitialPositionString = "1,2,N";
            var expected = new Position(1, 2 ){Direction = Direction.North};
            var actual = InputOutput.CreatePosition(testInitialPositionString);
            Assert.Equal(expected.XCoordinate, actual.XCoordinate);
            Assert.Equal(expected.YCoordinate, actual.YCoordinate);
            Assert.Equal(expected.Direction, actual.Direction);
        }

        [Fact]
        public void ParseCommandStringToAnArray()
        {
            const string testCommandString = "FFLBRF";
            var expected = new char[] {'F', 'F', 'L', 'B', 'R', 'F'};
            
            Assert.Equal(expected, InputOutput.ParseCommandToArray(testCommandString));

        }
        
    }
}