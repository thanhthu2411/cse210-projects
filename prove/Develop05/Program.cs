using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<Goal> goals = new List<Goal>();
        GoalManager gm = new GoalManager(goals);

        while (running)
        {
            gm.DisplayPoint();

            Console.Write("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Reset a goal\n7.Quit\nSelect a choice from the menu: ");
            string option = Console.ReadLine();
            if (option == "1")
            {
                gm.CreateNewGoal();
            }
            else if (option == "2")
            {
                gm.ListGoals();
            }
            else if (option == "3")
            {
                gm.SaveGoals();
            }
            else if (option == "4")
            {
                gm.LoadGoals();
            }
            else if (option == "5")
            {
                gm.RecordEvents();
            }
            else if (option == "6")
            {
                gm.ResetGoals();
            }
            else if (option == "7")
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

// for creativity, I added a new method to the Menu, which is "Reset a goal". This method allows 
// users to reset a goal that had been already completed.