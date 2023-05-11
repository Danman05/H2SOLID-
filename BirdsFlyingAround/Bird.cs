using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround
{
    public class Bird : IBirdFly
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}
