using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void CalculatePerimeterTest()
        {
            double sideLength = 5;
            double expectedPerimeter = sideLength * 4;
            Square square = new Square(sideLength);
            double actualPerimeter = square.CalculatePerimeter();
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void CalculateAreaTest()
        {
            double sideLength = 5;
            double expectedArea = sideLength * sideLength;
            Square square = new Square(sideLength);
            double actualArea = square.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}