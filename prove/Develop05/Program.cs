using System;

class Program
{
    static void Main(string[] args)
    {
        GoalOverview goalOverview = new GoalOverview();
        MainMenu mainMenu = new MainMenu();
        CreateGoalMenu createGoalMenu = new CreateGoalMenu();
        RecordEventMenu recordEventMenu = new RecordEventMenu();
 
        int userInput = 0;
 
        while (userInput != 9)
        {
            mainMenu.DisplayMenu();
            userInput = mainMenu.GetUserSelection();
        
            if (userInput == 1)
            {
                createGoalMenu.DisplayMenu();
                int userGoalInput = mainMenu.GetUserSelection();
                
                if (userGoalInput == 1)
                {
                    SimpleGoal newGoal = new SimpleGoal();
                    newGoal.CreateNewGoal();
                    goalOverview.AddGoaltoList(newGoal);
                } 
                else if (userGoalInput == 2)
                {
                    EternalGoal newGoal = new EternalGoal();
                    newGoal.CreateNewGoal();
                    goalOverview.AddGoaltoList(newGoal);
                } 
                else if (userGoalInput == 3)
                {
                    ChecklistGoal newGoal = new ChecklistGoal();
                    newGoal.CreateChecklistGoal();
                    goalOverview.AddGoaltoList(newGoal);
                } 
            }
            else if (userInput == 2)
            {
                goalOverview.DisplayGoals("Open Goals:", false);
            }
            else if (userInput == 3)
            {
                goalOverview.DisplayGoals("Completed Goals:", true);
            }
            else if (userInput == 4)
            {
                goalOverview.SaveToFile();
            }
            else if (userInput == 5)
            {
                goalOverview.LoadFromFile();
            }
            else if (userInput == 6)
            {
                recordEventMenu.DisplayMenu();
                userInput = mainMenu.GetUserSelection();
            }
            else if (userInput == 9)
            {
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
                Thread.Sleep(3000);
            }
        }
    }
}