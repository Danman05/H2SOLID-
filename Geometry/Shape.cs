
namespace Geometry
{

    // Shape class, Base class for other shapes

    public abstract class Shape
    {
        private double a;
        private string name;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructor
        // Sets values to a and name

        public Shape(double a, string name)
        {
            this.a = a;
            this.name = name;
        }

        public abstract double Perimeter();

        public abstract double Area();

    }
}
