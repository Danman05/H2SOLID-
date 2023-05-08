using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal abstract class LandAnimal : Animal, IWalk
    {
        protected LandAnimal(string name) : base(name)
        {
        }

        public void Walk()
        {
            Console.WriteLine("Animal is walking");
        }
    }
}
