using System;

namespace Shapes
{
    public class Triangle : IShape
    {
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }
        
        public double CalculatePerimeter()
        {
            return FirstSide + SecondSide + ThirdSide;
        }

        public double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p  - ThirdSide));
        }
    }
}