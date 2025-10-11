using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //getters and setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int t)
    {
        _top = t;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int b)
    {
        _bottom = b;
    }

    //
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}