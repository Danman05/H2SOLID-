
namespace OpenCloseCoffeeMachine
{
    public class WaterTank
    {
        private int currentCapacity;
        private int maxCapacity;
        public int CurrentCapacity { get; private set; }      
        public int MaxCapacity { get; private set; }
        public WaterTank()
        {
            currentCapacity = 0;
            maxCapacity = 1000;
        }

        public string AddWater()
        {
            if (currentCapacity < maxCapacity)
            {
                currentCapacity = maxCapacity;
                return $"Water tank filled, capacity is now: {currentCapacity}ml";
            }
            else
                return $"Water tank is already full";
        }

        public string RemoveWaterByBrewing(int waterRequiredToBrew)
        {
           
            if (currentCapacity > waterRequiredToBrew)
            {
                currentCapacity -= waterRequiredToBrew;
                return $"Water tank now has {currentCapacity}ml water";
            }
            else
                return $"Not enough water to brew";
            
        }
    }
}
