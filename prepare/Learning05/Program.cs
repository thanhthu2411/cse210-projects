using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square(1.2, "yellow");
        Rectangle r1 = new Rectangle(2, 3, "red");
        Circle c1 = new Circle(3, "blue");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape sh in shapes)
        {
            Console.WriteLine(sh.GetArea());
            Console.WriteLine(sh.GetColor());
        }
    }
}