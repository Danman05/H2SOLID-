using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
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

        public Shape(double a, string name)
        {
            this.a = a;
            this.name = name;
        }

        public abstract double Perimeter();

        public abstract double Area();

    }
}
