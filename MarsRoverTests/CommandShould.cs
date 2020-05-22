using kata_MarsRover;
using Xunit; 
using Moq;


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
            var grid = new Grid(3, 3);
            var sut = new Command(moveCommand, initialPosition, grid);
            var actual = sut.ExecuteMove();
            
            Assert.Equal(expected.XCoordinate, actual.XCoordinate);
            Assert.Equal(expected.YCoordinate, actual.YCoordinate);
            Assert.Equal(expected.Direction, actual.Direction);
        }
        

        
        
       
        
    }
}