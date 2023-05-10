
namespace Geometry
{
    // Square class, that inherits from Shape
    public class Square : Shape
    {

        // Constructor
        // Passes a and name to base constructor
        public Square(double a, string name) : base(a, name)
        {
        }

        public override double Perimeter()
        {
            return A * 4;
        }

        public override double Area()
        {
            return A * A;
        }
    }
}
