using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        Console.WriteLine($"{square.GetColor()} {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Red", 4, 5);
        Console.WriteLine($"{rectangle.GetColor()} {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 10);


        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("orange", 10));
        shapes.Add(new Rectangle("pink", 3, 5));
        shapes.Add(new Circle("brown", 7));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} {shape.GetArea()}");
        }
    }
}