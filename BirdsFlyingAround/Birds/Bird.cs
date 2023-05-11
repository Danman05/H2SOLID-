using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround.Birds
{
    public abstract class Bird
    {
        public abstract void SetLocation(double longitude, double latiude);
        public abstract void Draw();
    }
}
