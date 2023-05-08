using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square
    {

        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Square(double a)
        {
            this.a = a;
        }

        public double Perimeter()
        {
            return A * 4;
        }

        public double Area()
        {
            return A * A;
        }
    }
}
