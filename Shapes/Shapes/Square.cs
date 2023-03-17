namespace Shapes
{
    public class Square : IShape
    {
        public Square(double sideLength)
        {
            SideLength = sideLength;
        }
        
        public double SideLength { get; private set; }

        public double CalculatePerimeter()
        {
            return SideLength * 4;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}