using System;

class Program
{
    static void Main(string[] args)
    {

        int magicNumber;
        int guessNumber;
        string answer;
        bool playing = true;

        while (playing == true)
        {

            int counter = 0;
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 10);

        do
        {
            Console.Write("Your guess: ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            counter++;

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Bingo!");
                Console.WriteLine($"You made {counter} guesses.");
                Console.WriteLine($"Do you want to keep playing? ");
                answer = Console.ReadLine();
                if (answer.Trim().ToLower() == "yes")
                {
                    playing = true;
                }
                else
                {
                    playing = false;
                }
            }

        } while (magicNumber != guessNumber);

        }
    }
}