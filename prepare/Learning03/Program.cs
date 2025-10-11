using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Fraction f1 = new Fraction(6);
        Fraction f2 = new Fraction(6, 4);

        f.SetTop(1);
        f.SetBottom(4); 
        Console.WriteLine(f.GetBottom());
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
    }
}