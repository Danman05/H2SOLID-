using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseCoffeeMachine
{
    public abstract class Machine
    {
        protected bool isOn;

        public Machine()
        {
            isOn = false;
        }
        protected virtual string PowerOn()
        {
            if (!isOn)
            {
                isOn = true;
                return "Power is turned on";
            }
            else
                return "Power is already on";
        }
        protected virtual string PowerOff()
        {
            if (isOn)
            {
                isOn = false;
                return "Power is turned off";
            }
            else
                return "Power is already off";
        }
    }
}
