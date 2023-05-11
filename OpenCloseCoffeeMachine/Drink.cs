

namespace OpenCloseCoffeeMachine
{
    public abstract class Drink
    {
        private int waterRequiredToBrew;

        public int WaterRequiredToBrew
        {
            get { return waterRequiredToBrew; }
            set { waterRequiredToBrew = value; }
        }

        public Drink(int waterRequiredToBrew)
        {
            this.waterRequiredToBrew = waterRequiredToBrew;
        }
    }
}
