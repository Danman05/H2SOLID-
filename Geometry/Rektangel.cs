using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rektangel : Square
    {
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Rektangel(double a, double b) : base(a)
        {
            this.b = b;
        }
        public double Perimeter()
        {
            return A * 2 + B * 2;
        }

        public double Area()
        {
            return A * B;
        }
    }
}
