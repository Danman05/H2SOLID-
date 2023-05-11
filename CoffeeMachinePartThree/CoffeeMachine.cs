
namespace CoffeeMachinePartThree
{
    public class CoffeeMachine : Machine
    {

        private WaterTank WaterTank = new WaterTank();
        private CoffeeFilter CoffeeFilter = new CoffeeFilter();

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
