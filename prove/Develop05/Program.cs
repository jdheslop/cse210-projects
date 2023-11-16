/*
Exceeding Requirements:
- Have a menu item to display open goals and another menu item to display completed goals.
- When creating a new goal, there is the option to create a random SimpleGoal.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalOverview goalOverview = new GoalOverview();
        MainMenu mainMenu = new MainMenu();
        CreateGoalMenu createGoalMenu = new CreateGoalMenu();
 
        int userInput = -1;
 
        while (userInput != 0)
        {
            mainMenu.DisplayTotalPoints(goalOverview.GetTotalPoints());
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
                else if (userGoalInput == 4)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(1, 26);
                    SimpleGoal newGoal = new SimpleGoal(randomNumber);
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
                RecordEventMenu recordEventMenu = new RecordEventMenu(goalOverview.GetGoalList());
                recordEventMenu.DisplayMenu();
                int userSelection = mainMenu.GetUserSelection();
    	        goalOverview.RecordingEvents(userSelection);
                recordEventMenu.DisplayTotalPoints(goalOverview.GetTotalPoints());
            }
            else if (userInput == 0)
            {
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }
        }
    }
}