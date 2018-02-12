namespace MathLibrary.Shapes
{
    public class Rectangle : IShape
    {
        private double _lenght;
        private double _breadth;
        public Rectangle(double lenght, double breadth)
        {
            _lenght = lenght;
            _breadth = breadth;
        }
        public double GetArea()
        {
            return _lenght * _breadth;
        }

        public double GetPerimeter()
        {
            return 2 * (_lenght + _breadth);
        }

        public double GetNothing()
        {
            return 0;
        }
    }
}
