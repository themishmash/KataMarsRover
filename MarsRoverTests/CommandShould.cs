using kata_MarsRover;
using Xunit; 


namespace MarsRoverTests
{
    public class CommandShould
    {
        [Theory]
        [InlineData('F', 0, 1)]
        [InlineData('B', 0, 3)]
        public void InvokeCorrectMoveBasedOnCharacterInput(char moveCommand, int xCoordinate, int yCoordinate)
        {
            var initialPosition = new Position(0,0){Direction = Direction.North};
            var expected = new Position(xCoordinate, yCoordinate) {Direction = Direction.North };
            var sut = new Command(moveCommand, new Move(initialPosition, new Grid(3, 3)));
            var actual = sut.ExecuteMove();
            
            Assert.Equal(expected.XCoordinate, actual.XCoordinate);
            Assert.Equal(expected.YCoordinate, actual.YCoordinate);
            Assert.Equal(expected.Direction, actual.Direction);
        }
        
       
        
    }
}