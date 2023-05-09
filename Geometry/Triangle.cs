using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    // Triangel class, that inherits from Shape
    public class Triangle : Shape
    {
        private double b;
        private double c;

        public double B
        {
            get { return b; }
            set { b = value; }
        }


        // Constructor
        // Sets values to b and c
        // Passes a and name to base constructor
        public Triangle(double a, double b, string name) : base(a, name)
        {
            this.b = b;
            // Finding side c by using pythagoras
            this.c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
        }

        public override double Perimeter()
        {
            return A + b + c;
        }

        public override double Area()
        {
            return 0.5 * A * b;
        }
    }
}
