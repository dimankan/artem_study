using PloshadLibrary;
using System;
using Xunit;

namespace UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void GetPerimeter_ShouldReturnOk()
        {
            // Arrange
            Triangle triangle = new Triangle(4, 5, 6);

            // Act
            double perimetr = triangle.GetPerimeter();

            // Assert
            Assert.True(perimetr == 15);
        }

        [Fact]
        public void GetPerimeter_ShouldReturnFalse()
        {
            // Arrange
            Triangle triangle = new Triangle(4, 5, 6);

            // Act
            double perimetr = triangle.GetPerimeter();

            // Assert
            Assert.False(perimetr == 17);
        }
    }
}
