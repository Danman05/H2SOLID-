using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal abstract class Animal
    {
        private bool isAlive;

        private string? name;
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal(string name)
        {
            this.name = name;
        }
        public abstract void Breathe();

        public Animal Reproduce(Animal partner, string offSpringName)
        {
            return partner;
        }

        public abstract void Die(string cause);

    }
}
