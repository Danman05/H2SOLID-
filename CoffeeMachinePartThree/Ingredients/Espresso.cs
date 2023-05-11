
namespace CoffeeMachinePartThree.Ingredients
{
    internal class Espresso : Drink
    {
        private const int waterRequiredToBrewTea = 200;
        public Espresso() : base(waterRequiredToBrewTea)
        {
        }
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
