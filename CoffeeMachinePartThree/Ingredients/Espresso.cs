
namespace CoffeeMachinePartThree.Ingredients
{
    // Espresso derives from Drink and adds an property (waterRequiredToBrewEspresso)

    internal class Espresso : Drink
    {
        private const int waterRequiredToBrewEspresso = 200;

        // Constructor
        public Espresso() : base(waterRequiredToBrewEspresso)
        {
        }
        // Overrides to string method to get the drink type name
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
