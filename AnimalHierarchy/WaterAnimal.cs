using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal abstract class WaterAnimal : Animal, ISwim
    {
        public WaterAnimal(string name) : base(name) 
        {

        }

        public void Swim()
        {
            Console.WriteLine("Animal is Swimming");
        }
    }
}
