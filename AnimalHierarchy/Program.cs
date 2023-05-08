namespace AnimalHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WaterAnimal
            WaterAnimal squid = new Squid("SquidMan");
            WaterAnimal shark = new Shark("SharkMan");

            // LandAnimal
            LandAnimal beetle = new Beetle("BeetleMan");

            squid.Swim();
            squid.Die("Eaten by shark");
            squid.Breathe();
            Console.WriteLine(squid.Name);
            Console.WriteLine();

            shark.Swim();
            shark.Die("Died of age");
            shark.Breathe();
            Console.WriteLine(shark.Name);
            Console.WriteLine();


            beetle.Walk();
            beetle.Die("Stepped on by human");
            beetle.Breathe();
            Console.WriteLine(beetle.Name);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}