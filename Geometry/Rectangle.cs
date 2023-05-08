using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    // Rektangel class, that inherits from Shape
    public class Rectangle : Shape
    {
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        // Constructor
        // Sets values to b
        // Passes a and name to base constructor
        public Rectangle(double a, double b, string name) : base(a, name)
        {
            this.b = b;
        }
        public override double Perimeter()
        {
            return A * 2 + b * 2;
        }

        public override double Area()
        {
            return A * b;
        }
    }
}
