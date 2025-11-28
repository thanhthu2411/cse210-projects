
public class Running : Activity
{
    private double _distance;

    public Running(double distance, string date, double length, string type) : base(date, length, type)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance/GetLength() * 60;
    }

    public override double GetPace()
    {
        return GetLength()/_distance;
    }
}