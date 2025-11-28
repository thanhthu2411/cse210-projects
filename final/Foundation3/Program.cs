using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Maple Street", "Austin", "TX", "USA");
        Address a2 = new Address("87 Pine Ridge Ave", "Austin", "TX", "USA");
        Address a3 = new Address("123 Main Street", "Austin", "TX", "USA");

        Lecture l1 = new Lecture("Mark Green", 1000, "The Future of Artificial Intelligence", "A deep-dive lecture exploring upcoming breakthroughs in AI, how machine learning is evolving, and what the future may look like for technology and society.", "March 18, 2025", "11:30AM", a1, "Lecture");
        Reception r1 = new Reception("event@gmail.com", "Spring Networking Gala", "A professional networking reception where entrepreneurs, students, and industry leaders connect over refreshments and build relationships for future collaborations.",
                    "April 2, 2025", "3:00PM", a2, "Reception");
        Outdoor o1 = new Outdoor("sunny", "Sunset Community Picnic", "A relaxed outdoor event bringing families and friends together to enjoy food, games, and live music while celebrating the warm evening weather.",
                    "June 14, 2025", "6:30PM", a3, "Outdoor");

        Console.WriteLine("These are our available events: ");
        Console.WriteLine("\n *** Standard Details ***");
        Console.WriteLine(l1.StandardDetails());
        Console.WriteLine("-------------------");
        Console.WriteLine(r1.StandardDetails());
        Console.WriteLine("-------------------");
        Console.WriteLine(o1.StandardDetails());
        Console.WriteLine("\n *** Full Details ***");
        Console.WriteLine(l1.FullDetails());
        Console.WriteLine("-------------------");

        Console.WriteLine(r1.FullDetails());
        Console.WriteLine("-------------------");

        Console.WriteLine(o1.FullDetails());
        Console.WriteLine("\n *** Short Description ***");
        Console.WriteLine(l1.ShortDescription());
        Console.WriteLine("-------------------");

        Console.WriteLine(r1.ShortDescription());
        Console.WriteLine("-------------------");
        Console.WriteLine(o1.ShortDescription());
    }
}