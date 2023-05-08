using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class Beetle : LandAnimal
    {
        public Beetle(string name) : base(name)
        {
            this.Name = name;
        }

        public override void Breathe()
        {
            Console.WriteLine("Beetle is breathing");
        }

        public override void Die(string cause)
        {
            Console.WriteLine("An beetle died reason: {0}", cause);
        }

    }
}
