using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("blue", 5);
        Rectangle rectangle1 = new Rectangle("red", 5, 6);
        Circle circle1 = new Circle("orange", 6);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
    }
}