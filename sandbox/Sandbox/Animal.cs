public class Animal
{
    protected string _name;
    protected string _sound;

    public Animal(string name)
    {
        _name = name;
    }

    public void MakeNoise()
    {
        Console.WriteLine($"{_name} makes sound.");
    }
}