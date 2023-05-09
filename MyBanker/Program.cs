using System;

namespace MyBanker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            string chosenName = "";
            int age;
            List<string> randomNames = new List<string>()
            {
                "Guillermo Edwards",
                "Donovan Ritter",
                "Tucker Zhang",
                "Dana Sawyer",
                "Raphael Huffman",
                "Axel Rodriguez",
                "Lawrence Murray",
                "Evie Jensen",
                "Eyna York",
                "Myah Phillips",
                "Darryl Day",
                "Victoria Atkinson",
                "Jazmin Bishop",
                "Izabelle Davies",
                "Kareem Hicks",
                "Jair Burnett",
                "Malik Irwin",
                "Deangelo Archer",
                "Karlie Zavala",
                "Trevin Trevino"
            };

            while (true)
            {

                chosenName = randomNames[random.Next(0, 20)];
                age = random.Next(10, 120);

                switch (random.Next(0, 4))
                {
                    case 0:
                        if (age < 18)
                        {
                            Card debitCard = new DebitCard(chosenName, age);
                            Console.WriteLine(debitCard.ToString());
                        }
                        else if (age >= 18)
                        {
                            Card maestroCard = new Maestro(chosenName, age);
                            Console.WriteLine(maestroCard.ToString());
                        }
                        break;

                    case 1:
                        if (age >= 15)
                        {
                            Card visaElectronCard = new VisaElectron(chosenName, age);
                            Console.WriteLine(visaElectronCard.ToString());
                        }
                        else if (age < 15)
                        {
                            Card debitCard = new DebitCard(chosenName, age);
                            Console.WriteLine(debitCard.ToString());
                        }
                        break;
                    case 2:
                        if (age >= 18)
                        {
                            Card visaCard = new Visa(chosenName, age);
                            Console.WriteLine(visaCard.ToString());
                        }
                        else if (age < 18)
                        {
                            Card debitCard = new DebitCard(chosenName, age);
                            Console.WriteLine(debitCard.ToString());
                        }
                        break;
                    case 3:
                        if (age >= 18)
                        {
                            Card masterCard = new Mastercard(chosenName, age);
                            Console.WriteLine(masterCard.ToString());
                        }
                        else if (age < 18)
                        {
                            Card debitCard = new DebitCard(chosenName, age);
                            Console.WriteLine(debitCard.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Hello world");
                        break;
                }
                Thread.Sleep(5000);
                Console.Clear();
            }



            // Card debit = new DebitCard("Emil", 16);
            //Console.WriteLine(debit.ToString());

            // Card visaElectron = new VisaElectron("Daniel", 18);
            // Console.WriteLine(visaElectron.ToString());

        }
    }
}