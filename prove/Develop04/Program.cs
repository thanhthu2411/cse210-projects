using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        List<string> reflectionPromptList = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Prompts reflectionPrompts = new Prompts(reflectionPromptList);

        List<string> reflectionQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        List<string> listingPromptList = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Prompts listingPrompts = new Prompts(listingPromptList);
        BreathingActivity b1 = new BreathingActivity(4, 6, "Breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        ReflectionActivity r1 = new ReflectionActivity(reflectionPrompts, reflectionQuestions, "Reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        ListingActivity l1 = new ListingActivity(listingPrompts, "Listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");


        // menu
        while (running)
        {
            Console.Write("Menu Options:\n1.Start breathing activity\n2.Start reflecting activity\n3.Start listing activity\n4.Quit\nSelect a choice from the menu:  ");
            string option = Console.ReadLine();
            if (option == "1")
            {
                b1.Run();
            }
            else if (option == "2")
            {
                r1.Run();
            }
            else if (option == "3")
            {
                l1.Run();
            }
            else if (option == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid input.\n");
            }

        }
    }
}

// for creativity, I make sure no random prompts/questions are selected until they have all been used at least once in that session. I also created a new animation for the reflection activity.
