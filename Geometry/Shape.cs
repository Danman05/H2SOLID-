using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Shape
    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public Shape(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public abstract double Perimeter();

        public abstract double Area();
    }
}
