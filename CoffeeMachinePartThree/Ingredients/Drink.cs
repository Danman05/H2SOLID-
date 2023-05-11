namespace CoffeeMachinePartThree.Ingredients
{
    // Drink class
    public abstract class Drink
    {
        private int waterRequiredToBrew;

        public int WaterRequiredToBrew
        {
            get { return waterRequiredToBrew; }
            set { waterRequiredToBrew = value; }
        }

        // Constructor
        public Drink(int waterRequiredToBrew)
        {
            this.waterRequiredToBrew = waterRequiredToBrew;
        }
    }
}
