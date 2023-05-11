

namespace OpenCloseCoffeeMachine
{
    public class CoffeeFilter : CoffeeMachine
    {

        private static Coffee coffee = new();

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
