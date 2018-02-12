namespace MathLibrary.Shapes
{
    public class Square : IShape
    {
        private double _length;

        public Square(double length)
        {
            _length = length;
        }

        public double GetArea()
        {
            return _length * _length;
        }

        public double GetPerimeter()
        {
            return _length + _length;
        }
    }
}
