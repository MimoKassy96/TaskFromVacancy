using CalculateAreaLib.Models;
using CalculateAreaLib.Models.Enums;
using CalculateAreaLib.Services;

namespace CalculateAreaLibTests
{
    public class UnitTest
    {
        [Fact]
        public void CalculateAreaTriangleTest_Rusult_Equal_6()
        {
            // Arrange
            var triangle = new TriangleParam() { figure = Figure.Trialnge, SideA = 3, SideB = 4, SideC = 5 };
            var servise = new CalculateAreaService();
            // Act
            var result = servise.CalculateAreaTriangle(triangle);
            // Assert
            Assert.Equal(6 ,result);
        }

        [Fact]
        public void CalculateAreaCircleleTest_Rusult_Equal_113()
        {
            // Arrange
            var circle = new CircleParam() { figure = Figure.Circle, Radius = 6 };
            var servise = new CalculateAreaService();
            // Act
            var result = servise.CalculateAreaCircle(circle);
            // Assert
            Assert.Equal(113,1 , result);
        }

        [Fact]
        public void CheckRightTriangleTest_Rusult_true()
        {
            // Arrange
            var triangle = new TriangleParam() { figure = Figure.Trialnge, SideA = 3, SideB = 4, SideC = 5 };
            var servise = new CalculateAreaService();
            // Act
            var result = servise.CheckRightTriangle(triangle);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CheckFigureAndFindAreaTest_Rusult_6()
        {
            // Arrange
            var triangle = new TriangleParam() { figure = Figure.Trialnge, SideA = 3, SideB = 4, SideC = 5 };
            var servise = new CalculateAreaService();
            // Act
            var result = servise.CheckFigure(triangle);
            // Assert
            Assert.Equal(6, result);
        }
    }
}