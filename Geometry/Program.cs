

namespace Geometry
{
    public class Program
    {
        static void Main()
        {
            // Adds differents shapes to an list of Shape
            List<Shape> shapeList = new() 
            {
                new Square(10, "Square"),
                new Parallelogram(5,15,70, "Parellelogram"),
                new Trapez(10, 9, 8 , 9, "Trapez"),
                new Rectangle(5, 10, "Rectangle"),
                new Triangle(3, 5, "Triangle")
            };

            // Loops through each item in the list of Shape
            foreach (Shape shape in shapeList)
            {
                Console.WriteLine($"{shape.Name} perimeter: {shape.Perimeter()}\n" +
                    $"{shape.Name} area: {shape.Area()}\n");

            }

            Console.ReadLine();
        }
    }
}