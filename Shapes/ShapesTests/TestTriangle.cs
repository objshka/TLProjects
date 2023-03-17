using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TestPerimeter()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var expectedPerimeter = 12;

            // Act
            var actualPerimeter = triangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void TestArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6;

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void TestSides()
        {
            // Arrange
            var firstSide = 3;
            var secondSide = 4;
            var thirdSide = 5;

            // Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(firstSide, triangle.FirstSide);
            Assert.AreEqual(secondSide, triangle.SecondSide);
            Assert.AreEqual(thirdSide, triangle.ThirdSide);
        }
    }
}