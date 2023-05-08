namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();
            List<Square> list2 = new();



            // Square test
            Square square = new(10);
            list2.Add(square);
            Console.WriteLine($"Square Perimeter: {square.Perimeter()}");
            Console.WriteLine($"Square Area: {square.Area()}\n");

            // Parallelogram test

            Parallelogram parallelogram = new(5, 15, 70);
            list2.Add(parallelogram);
            Console.WriteLine($"Parallelogram Perimeter: {parallelogram.Perimeter()}");
            Console.WriteLine($"Parallelogram Area: {parallelogram.Area()}\n");

            // Trapez test

            Trapez trapez = new(10, 9, 8, 9);
            list2.Add(trapez);
            Console.WriteLine($"Trapez Area: {trapez.Perimeter()}");
            Console.WriteLine($"Trapez Perimeter: {trapez.Area()}\n");


            // Rektangel test

            Rektangel rektangel = new(5, 10);
            list2.Add(rektangel);
            Console.WriteLine($"Rektangel Perimeter: {rektangel.Perimeter()}");
            Console.WriteLine($"Rektangel Area: {rektangel.Area()}\n");

            // Triangle test

            Triangle triangle = new(3, 5);
            list.Add(triangle);
            Console.WriteLine($"Triangle Perimeter: {triangle.Perimeter()}");
            Console.WriteLine($"Triangle Area: {triangle.Area()}\n");

            foreach (var item in list2)
            {
                Console.WriteLine(item.Perimeter());
                Console.WriteLine(item.Area());
            }
            Console.ReadLine();
        }
    }
}