
namespace CoffeeMachinePartThree
{
    public class CoffeeMachine : Machine
    {

        private WaterTank waterTank = new WaterTank();
        private Filter coffeeFilter = new Filter();

        public string Brew(object drink)
        {

            return $"{waterTank.AddWater()}\n" +
                $"{coffeeFilter.AddFilter()}\n" +
                $"{PowerOn()}\n" +
                $"{drink} is being brewed\n" +
                $"{waterTank.RemoveWaterByBrewing(coffeeFilter.Coffee.WaterRequiredToBrew)}\n" +
                $"{PowerOff()}\n" +
                $"{coffeeFilter.RemoveFilter()}";
        }
    }
}
