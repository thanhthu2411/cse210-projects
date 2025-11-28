using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> cl1 = new List<Comment>
    {
        new Comment("Anna Snow", "Great video! Learned something new today."),
        new Comment("Mark Jensen", "Super helpful explanation, thanks!"),
        new Comment("Amy Rivera", "Didn’t expect it to be this good.")
    };

        List<Comment> cl2 = new List<Comment>
    {
        new Comment("Chris Miller", "This helped me a lot, thanks!"),
        new Comment("Sofia Tran", "Really clear explanation."),
        new Comment("Tom Perez", "Can you make a part 2?")
    };

        List<Comment> cl3 = new List<Comment>
    {
        new Comment("Lily Jones", "I’m trying this starting today!"),
        new Comment("David Kim", "Very motivating."),
        new Comment("Marry Chen", "Love these tips!")
    };

        Video v1 = new Video("5 English words every day", "Harley Smith", 300, cl1);
        Video v2 = new Video("Learn C# for Beginners", "Dev Mastery", 480, cl2);
        Video v3 = new Video("10 Healthy Habits You Can Start Today", "LifeBoost Channel", 720, cl3);

        List<Video> videoList = new List<Video> {v1, v2, v3};

        foreach(Video v in videoList)
        {
            v.DisplayInfor();
            Console.WriteLine("** Comment section **");
            v.DisplayComments();
            Console.WriteLine("");
        }
    }
}