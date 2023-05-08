using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class Shark : WaterAnimal
    {

        public Shark(string name) : base(name)
        {
            this.Name = name;
        }
        public override void Breathe()
        {
            Console.WriteLine("Shark is breathing");
        }

        public override void Die(string cause)
        {
            Console.WriteLine("An Shark died reason: {0}", cause);
        }
    }
}
