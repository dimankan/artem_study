using PloshadLibrary;
using System;
using Xunit;

namespace UnitTests
{
    public class TrianglePloshadTests
    {
        [Fact]
        public void GetPloshad_ShouldReturnOk()
        {
            // Arrange
            Triangle triangle = new Triangle(4,5,6);

            // Act
            double ploshad = triangle.GetArea();

            // Assert
            Assert.True(ploshad == 9.921567416492215);
        }

        [Fact]
        public void GetPloshad_ShouldReturnFalse()
        {
            // Arrange
            Triangle triangle = new Triangle(4, 5, 6);

            // Act
            double ploshad = triangle.GetArea();

            // Assert
            Assert.False(ploshad == 17);
        }
    }
}
