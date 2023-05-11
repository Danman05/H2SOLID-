
namespace OpenCloseCoffeeMachine
{
    public class CoffeeMachine : Machine
    {

        private static WaterTank WaterTank = new();
        private static CoffeeFilter CoffeeFilter = new();

        public string Brew(object drink)
        {

            return $"{WaterTank.AddWater()}\n" +
                $"{CoffeeFilter.AddFilter()}\n" +
                $"{PowerOn()}\n" +
                $"{drink} is being brewed\n" +
                $"{WaterTank.RemoveWaterByBrewing(CoffeeFilter.Coffee.WaterRequiredToBrew)}\n" +
                $"{PowerOff()}\n" +
                $"{CoffeeFilter.RemoveFilter()}";
        }
    }
}
