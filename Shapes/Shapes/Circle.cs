using System;

namespace Shapes
{
    public class Сircle : IShape
    {
        public Сircle(double sideLength)
        {
            Radius = sideLength;
        }
        
        public double Radius { get; private set; }
        
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}