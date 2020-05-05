using kata_MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class GridShould
    {
        [Fact]
        public void GenerateGridAccordingToSpecifiedDimensions()
        {
           var sut = new Grid(3, 3);
           var expectedGrid = new Square[,]
           {
               {new Square(0,0), new Square(0,1), new Square(0,2) },
               {new Square(1,0), new Square(1,1), new Square(1,2) },
               {new Square(2,0), new Square(2,1), new Square(2,2) },
               
           };

           var actualGrid = sut.GenerateGrid();

           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 3; j++)
               {
                   Assert.Equal(expectedGrid[i,j].XCoordinate, actualGrid[i,j].XCoordinate );
                   Assert.Equal(expectedGrid[i,j].YCoordinate, actualGrid[i,j].YCoordinate );
               }
               
           }

           Assert.Equal(9, sut.GenerateGrid().Length);

        }

    }
}