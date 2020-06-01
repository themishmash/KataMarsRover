using kata_MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class InputOutputShould
    {
        [Fact]
        public void ParseStringToCoordinates()
        {
            var expected = new int[] {1, 2};
            const string testInitialPositionString = "1,2,N";
            var actual = InputOutput.ParseStringCoordinatesToInt("1, 2");
            
            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);

        }

        [Fact]
        public void ParseStringToDirection()
        {
            const Direction expected = Direction.East;
            var actual = InputOutput.ParseStringToDirection("E");
            
            Assert.Equal(expected, actual);
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