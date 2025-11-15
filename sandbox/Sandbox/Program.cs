using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Animal myPet = new Animal("Ali");
        myPet.MakeNoise();

        Rabbit r = new Rabbit("Shadow");
        r.MakeNoise();

    }
}