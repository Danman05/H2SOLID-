
namespace CoffeeMachinePartTwo.Ingredients
{
    public class Tea : Drink
    {
        private const int waterRequiredToBrewTea = 200;
        public Tea() : base(waterRequiredToBrewTea)
        {
        }
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
