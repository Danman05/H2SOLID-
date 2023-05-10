
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

        public string FillWaterTank()
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
