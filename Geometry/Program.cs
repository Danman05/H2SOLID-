

namespace Geometry
{
    public class Program
    {
        static void Main()
        {

            List<Shape> shapeList = new();

            Square square = new(10, "Square");
            Parallelogram parallelogram = new(5, 15, 70, "Parallelogram");
            Trapez trapez = new(10, 9, 8, 9, "Trapez");
            Rectangle rectangle = new(5, 10, "Rectangle");
            Triangle triangle = new(3, 5, "Triangle");

            shapeList.Add(square);
            shapeList.Add(parallelogram);
            shapeList.Add(trapez);
            shapeList.Add(rectangle);
            shapeList.Add(triangle);

            foreach (Shape shape in shapeList)
            {
                Console.WriteLine($"{shape.Name} perimeter: {shape.Perimeter()}\n" +
                    $"{shape.Name} area: {shape.Area()}\n");

            }

            Console.ReadLine();


            // Square test

            //Console.WriteLine($"Square Perimeter: {square.Perimeter()}");
            //Console.WriteLine($"Square Area: {square.Area()}\n");

            // Parallelogram test

            //Console.WriteLine($"Parallelogram Perimeter: {parallelogram.Perimeter()}");
            //Console.WriteLine($"Parallelogram Area: {parallelogram.Area()}\n");

            // Trapez test

            //Console.WriteLine($"Trapez Area: {trapez.Perimeter()}");
            //Console.WriteLine($"Trapez Perimeter: {trapez.Area()}\n");


            // Rectangle test

            //Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter()}");
            //Console.WriteLine($"Rectangle Area: {rectangle.Area()}\n");

            // Triangle test

            //Console.WriteLine($"Triangle Perimeter: {triangle.Perimeter()}");
            //Console.WriteLine($"Triangle Area: {triangle.Area()}\n");

        }
    }
}