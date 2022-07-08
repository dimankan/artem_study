using PloshadLibrary;
using System;
using Xunit;

namespace UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void GetPloshad_ShouldReturnOk()
        {
            // Arrange
            Circle circle = new Circle(6);

            // Act
            double ploshad = circle.GetArea();

            // Assert
            Assert.True(ploshad == 113.09733552923255);
        }

        [Fact]
        public void GetPloshad_ShouldReturnFalse()
        {
            // Arrange
            Circle circle = new Circle(6);

            // Act
            double perimetr = circle.GetArea();

            // Assert
            Assert.False(perimetr == 17);
        }
    }
}
