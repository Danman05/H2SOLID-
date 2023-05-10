
namespace Geometry
{

    // Parallelogram class, that inherits from Shape
    public class Parallelogram : Shape
    {
        private double b;
        private double angle;

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        // Constructor
        // Sets values to b and v
        // Passes a and name to base constructor
        public Parallelogram(double a, double b, double angle, string name) : base(a, name)
        {
            this.b = b;
            this.angle = angle;
        }

        public override double Perimeter()
        {
            return A * 2 + b * 2;
        }

        public override double Area()
        {
            return A * b * Math.Sin(angle);
        }
    }
}
