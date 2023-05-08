using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    // Trapez class, that inherits from Shape
    internal class Trapez : Shape
    {
		private double b;
		private double c;
		private double d;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
		{
			get { return c; }
			set { c = value; }
		}
		public double D
		{
			get { return d; }
			set { d = value; }
		}

        // Constructor
        // Sets values to b, c and d
        // Passes a and name to base constructor
        public Trapez (double a, double b, double c, double d, string name) : base(a, name)
		{
            this.b = b;
			this.c = c;
			this.d = d;
		}

        public override double Perimeter()
        {
            return A + b + c + d;
        }

        public override double Area()
        {
            double s = (A + b - c + d) / 2;
            double height = 2 / (A - c) * (Math.Sqrt(s * (s - A + c) * (s - b) * (s - d)));
            return 0.5 * (A + c) * height;
        }
    }
}
