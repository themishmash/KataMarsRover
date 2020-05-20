using kata_MarsRover;
using Xunit; 


namespace MarsRoverTests
{
    public class CommandShould
    {
        [Fact]
        public void InvokeCorrectMoveBasedOnCharacterInput()
        {
            var initialPosition = new Position(0,0){Direction = Direction.North};
            var moveCommand = 'F';
            var expected = new Position(0, 1) {Direction = Direction.North };
            
            var actual = Command.Move(moveCommand);
            
            Assert.Equal(expected.XCoordinate, actual.XCoordinate);
            Assert.Equal(expected.YCoordinate, actual.YCoordinate);
            Assert.Equal(expected.Direction, actual.Direction);

        }
        
    }
}