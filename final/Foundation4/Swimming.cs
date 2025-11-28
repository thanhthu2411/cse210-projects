


public class Swimming : Activity
{
    private int _lapNumber;

    public Swimming(int num, string date, double length, string type) : base(date, length, type)
    {
        _lapNumber = num;
    }

    public override double GetDistance()
    {
        return _lapNumber * 50/ 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

    public override double GetPace()
    {
        return 60/GetSpeed();
    }
}