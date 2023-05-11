using BirdsFlyingAround.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround.Birds
{
    public class Eagle : Bird, IFly, IHunt
    {
        public override void SetLocation(double longitude, double latiude)
        {
            throw new NotImplementedException();
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
        public void SetAltiude(double altiude)
        {
            throw new NotImplementedException();
        }
        public void SearchForPrey()
        {
            throw new NotImplementedException();
        }
        public void CapturePrey()
        {
            throw new NotImplementedException();
        }

        public void ConsumePrey()
        {
            throw new NotImplementedException();
        }




    }
}
