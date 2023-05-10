
namespace Geometry
{
    // Square class, that inherits from Shape
    public class Square : Shape
    {

        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        // Constructor
        // Passes a and name to base constructor
        public Square(double a, string name) : base(a, name)
        {
        }

        public override double Perimeter()
        {
            return base.A * 4;
        }

        public override double Area()
        {
            return base.A * base.A;
        }
    }
}
