using System.Collections.Generic;
using System.Data;
using kata_MarsRover;
using Xunit;
using Moq;

namespace MarsRoverTests
{
    public class MoveShould
    {
        private Move SutN;
        private Move SutE;
        private Move SutS;
        public MoveShould()
        {
            SutN = new Move(new Position(0,0), Direction.N, new Grid(3,3));
            
            SutE = new Move(new Position(0,0), Direction.E, new Grid(3,3));
            SutS = new Move(new Position(0,0), Direction.S, new Grid(3,3));
        }
        [Fact]
        public void YCoordinateIncreaseByOneWhenFacingNorthAndMovingForward()
        {
            
            var actualResult = SutN.Forward();
            var expectedResult = new Position(0, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        public void YCoordinateResetsToOneWhenMovingForwardAndFacingNorthFromMaximumLength()
        {
            var sut = new Move(new Position(0, 3), Direction.N, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Position(0, 0);
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        public void XCoordinateIncreasesByOneWhenFacingEastAndMovingForward()
        {
            
            var actualResult = SutE.Forward();
            var expectedResult = new Position(1, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }

        
        
        [Fact]
        public void YCoordinateDecreasesByOneWhenFacingSouthAndMovingForward()
        {
            
            var actualResult = SutS.Forward();
            var expectedResult = new Position(0, 2);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        

    }
}