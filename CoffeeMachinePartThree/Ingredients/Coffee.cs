namespace CoffeeMachinePartThree.Ingredients
{
    public class Coffee : Drink
    {

        private const int waterRequiredToBrewCoffee = 250;

        // Constructor
        public Coffee() : base(waterRequiredToBrewCoffee)
        {
        }
        // Overrides to string method to get the drink type name
        public override string ToString()
        {
            return GetType().Name;
        }

    }
}
