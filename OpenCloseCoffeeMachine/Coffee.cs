
namespace OpenCloseCoffeeMachine
{
    public class Coffee : Drink
    {
        private const int waterRequiredToBrewCoffee = 250;
        public Coffee() : base(waterRequiredToBrewCoffee)
        {
        }

        public override string ToString()
        {
            return GetType().Name;
        }

    }
}
