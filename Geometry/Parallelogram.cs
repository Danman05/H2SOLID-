using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Parallelogram : Square
    {
        private double b;
        private double v;

        public double V
        {
            get { return v; }
            set { v = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Parallelogram(double a, double b, double v) : base(a)
        {
            this.b = b;
            this.v = v;
        }

        public double Perimeter()
        {
            return A * 2 + B * 2;
        }

        public double Area()
        {
            return A * B * Math.Sin(V);
        }
    }
}
