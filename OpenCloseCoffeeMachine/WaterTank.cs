using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseCoffeeMachine
{
    public class WaterTank
    {
        private int currentCapacity;
        private int maxCapacity;

        public WaterTank() 
        {
            currentCapacity = 0;
            maxCapacity = 1000;
        }

        private string FillWaterTank()
        {
            if (currentCapacity < maxCapacity)
            {
                return $"Water tank filled, capacity is now: {currentCapacity}";
            }
            else
                return $"Water tank is already full";
        }
    }
}
