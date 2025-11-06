public class Circle:Shape
{
    private double _radius;

    public Circle(double r, string c) : base(c)
    {
        _radius = r;
    }

    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
}