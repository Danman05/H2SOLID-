namespace OpenCloseCoffeeMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine();
            bool programIsAlive = true;
            ConsoleKeyInfo cki;

            while (programIsAlive)
            {
                Console.WriteLine("1. Brew Coffee\n" +
                    "0. Leave machine");
                cki = Console.ReadKey();

                switch (cki.KeyChar)
                {
                    case '1':
                        Console.WriteLine(machine.Brew(new Coffee()));
                        break;

                    case '0':
                        programIsAlive = false;
                        break;
                        
                    default:
                        Console.WriteLine("Not an valid drink");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}