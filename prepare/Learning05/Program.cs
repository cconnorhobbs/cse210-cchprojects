using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Blue", 8);
        shapes.Add(square1);
        Console.WriteLine(square1.GetArea());
        Console.WriteLine(square1.GetColor());

        Circle circle1 = new Circle("Red", 7);
        shapes.Add(circle1);
        Console.WriteLine(circle1.GetArea());
        Console.WriteLine(circle1.GetColor());

        Square rectangle1 = new Square("Yellow", 6);
        shapes.Add(rectangle1);
        Console.WriteLine(rectangle1.GetArea());
        Console.WriteLine(rectangle1.GetColor());
    }
}