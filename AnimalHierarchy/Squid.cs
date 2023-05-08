using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class Squid : WaterAnimal
    {
        public Squid(string name) : base(name)
        {
            this.Name = name;
        }

        public override void Breathe()
        {
            Console.WriteLine("Squid is breathing");
        }

        public override void Die(string cause)
        {
            Console.WriteLine("Squid died reason: {0}", cause);
        }
    }
}
