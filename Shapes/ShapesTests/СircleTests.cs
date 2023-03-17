using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class СircleTests
    {
        [Test]
        public void CalculatePerimeterTest()
        {
            double radius = 5;
            double expectedPerimeter = 2 * Math.PI * radius;
            Сircle circle = new Сircle(radius);
            double actualPerimeter = circle.CalculatePerimeter();
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void CalculateAreaTest()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            Сircle circle = new Сircle(radius);
            double actualArea = circle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}