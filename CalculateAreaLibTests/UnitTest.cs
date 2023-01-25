using CalculateAreaLib.Models;
using CalculateAreaLib.Services;

namespace CalculateAreaLibTests
{
    public class UnitTest
    {
        [Fact]
        public void CalculateAreaTriangleTest_Rusult_Equal_6()
        {
            // Arrange
            var sideA = 3.0;
            var sideB = 4.0;
            var sideC = 5.0;
            var triangle = new TriangleParam(sideA , sideB, sideC);
            var servise = new CalculateAreaService();

            // Act
            var result = servise.GetFigureArea(triangle);

            // Assert
            Assert.Equal(6 ,result);
        }

        [Fact]
        public void CalculateAreaCircleleTest_Rusult_Equal_113()
        {
            // Arrange
            var radius = 6.0;
            var circle = new CircleParam(radius);
            var servise = new CalculateAreaService();

            // Act
            var result = servise.GetFigureArea(circle);

            // Assert
            Assert.Equal(113,1 , result);
        }

        [Fact]
        public void CheckRightTriangleTest_Rusult_true()
        {
            // Arrange
            var sideA = 3.0;
            var sideB = 4.0;
            var sideC = 5.0;
            var triangle = new TriangleParam(sideA, sideB, sideC);

            // Act
            var result = triangle.CheckRightTriangle(triangle);

            // Assert
            Assert.True(result);
        }
    }
}