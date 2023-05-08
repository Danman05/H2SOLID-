using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Shape
    {
        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public Triangle(double a, double b) : base(a, b)
        {
            // Finding side c by using pythagoras
            this.c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
        }

        public override double Perimeter()
        {
            return A + B + C;
        }

        public override double Area()
        {
            return 0.5 * A * B;
        }
    }
}
