using System;

class Program
{      
    static void Main(string[] args)
    {
        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("yellow", 5, 6);
        Circle circle = new Circle("green", 4);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} area is {area}.");
        }
    }
}