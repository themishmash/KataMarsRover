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
            const char moveCommand = 'F';
            var expected = new Position(0, 1) {Direction = Direction.North };
            var sut = new Command(moveCommand, initialPosition, new Grid(3,3));
            var actual = sut.ExecuteMove();
            
            Assert.Equal(expected.XCoordinate, actual.XCoordinate);
            Assert.Equal(expected.YCoordinate, actual.YCoordinate);
            Assert.Equal(expected.Direction, actual.Direction);

        }
        
    }
}