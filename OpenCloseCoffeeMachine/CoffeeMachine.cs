
namespace OpenCloseCoffeeMachine
{
    public class CoffeeMachine : Machine
    {
        private WaterTank waterTank;
        private CoffeeFilter coffeeFilter;

        public CoffeeMachine() 
        {
            this.waterTank = new WaterTank();
            this.coffeeFilter = new CoffeeFilter();
        }
    }
}
