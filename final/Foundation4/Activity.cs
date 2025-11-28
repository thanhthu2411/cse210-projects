
using System.ComponentModel.DataAnnotations;

public class Activity
{
    private string _date;
    private double _length;

    private string _type;

    public Activity(string date, double length, string type)
    {
        _date = date;
        _length = length;
        _type = type;
    } 

    public double GetLength()
    {
        return _length;
    }

    public virtual double GetDistance()
    {
        return 1;
    }

    public virtual double GetSpeed()
    {
        return 1;
    }

    public virtual double GetPace()
    {
        return 1;
    }

    public string GetSummary()
    {
        return $"{_date} {_type} ({_length} min)- Distance {Math.Round(GetDistance(), 2)} km, Speed: {Math.Round(GetSpeed(), 2)} kph, Pace: {Math.Round(GetPace(), 2)} min per km";
    }

}