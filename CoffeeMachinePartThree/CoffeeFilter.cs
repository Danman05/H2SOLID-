using CoffeeMachinePartThree.Ingredients;

namespace CoffeeMachinePartThree
{
    public class CoffeeFilter
    {

        private Coffee coffee = new Coffee();

        public Coffee Coffee
        {
            get { return coffee; }
            set { coffee = value; }
        }

        public string AddFilter()
        {
            return $"Coffee filter added";
        }

        public string RemoveFilter()
        {
            return $"Coffee filter removed";
        }
    }
}
