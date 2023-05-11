using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround.Interface
{
    public interface IHunt
    {
        void SearchForPrey();
        void CapturePrey();
        void ConsumePrey();
    }
}
