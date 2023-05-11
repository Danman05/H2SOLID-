
namespace CoffeeMachinePartThree.Ingredients
{
    // Tea derives from Drink and adds an property (waterRequiredToBrewTea)
    public class Tea : Drink
    {
        private const int waterRequiredToBrewTea = 200;

        // Constructor
        public Tea() : base(waterRequiredToBrewTea)
        {
        }
        // Overrides to string method to get the drink type name
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
