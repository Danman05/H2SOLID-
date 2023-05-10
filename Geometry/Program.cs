

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
        }
    }
}