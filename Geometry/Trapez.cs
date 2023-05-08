using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Trapez : Square
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

		public Trapez (double a, double b, double c, double d) : base(a)
		{
			this.b = b;
			this.c = c;
			this.d = d;
		}

        public double Perimeter()
        {
            return A + B + C + D;
        }

        public double Area()
        {
			double s = (A + B - C + D) / 2;
			double height = 2 / (A - C) * (Math.Sqrt(s * (s - A + C) * (s - B) * (s - D)));
			return 0.5 * (A + C) * height;
        }
    }
}
