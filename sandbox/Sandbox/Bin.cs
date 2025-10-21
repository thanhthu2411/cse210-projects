
class Bin
{
    private string _denomination;
    private double _value;
    private int _count;

    // behaviors
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }

    public void Alter(int delta)
    {
        _count += delta;
    }

    public string getDenomination() { return _denomination; }
    public int getCount() { return _count; }
}