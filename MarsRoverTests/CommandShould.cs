using kata_MarsRover;
using Xunit; 
using Moq;


namespace MarsRoverTests
{
    public class CommandShould
    {
        // public CommandShould()
        // {
        //   
        //     mockMove = new Mock<IMove>();
        //     sut = new Command(new char[]{'F','B','R','L'}, mockMove.Object);
        //     var actual = sut.ExecuteCommands();
        // }
        //
        // Mock<IMove> mockMove;
        // Command sut;

        [Fact]
        public void MoveForwardWithFCommand()
        {
            var sut = new Command(new char[]{'F','B','R','L'}, new Position(1, 1){Direction = Direction.North}, new Grid(3, 3));
            var actual = sut.MoveRover();
            
            var expected = new Position(1, 1);
            Assert.Equal(expected.XCoordinate, actual.XCoordinate);
            Assert.Equal(expected.YCoordinate, actual.YCoordinate);
        }
        
        [Fact]
        public void MoveBackwardWithBCommand()
        {

            //mockMove.Verify(m => m.Backward(), Times.Once);
        }
        
        [Fact]
        public void MoveRightWithRCommand()
        {
            //mockMove.Verify(m => m.Right(), Times.Once);
        }
        
        [Fact]
        public void MoveLeftWithLCommand()
        {
           // mockMove.Verify(m => m.Left(), Times.Once);
        }
        
        

    }
}