using System;
using System.IO;
 
public class GoalOverview
{
    //Attributes
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;
    private string _fileName;
 
    //Constructor
    public GoalOverview()
    {
        _totalPoints = 0;
    }
 
    //Methods
    public void AddGoaltoList(Goal goal)
    {
        _goals.Add(goal);
    }

    public void IncreaseTotalPoints(int points)
    {
        _totalPoints += points;
    }
 
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public List<Goal> GetGoalList()
    {
        return _goals;
    }

    public void DisplayGoals(string prompt, bool status)
    {
        int counter = 1;
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine(prompt);

        foreach (Goal goal in _goals)
        {
            if (goal.GetIsComplete() == status)
            {
                Console.Write($"{counter}. ");
                goal.DisplayGoal();
                counter += 1;
            }
        }

        Console.WriteLine();
        Console.Write("Press enter to return to the main menu.");
        Console.ReadLine();
    }
 
    public string GetFileName()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        Console.WriteLine();
        return fileName;
    }
 
    public void SaveToFile()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Save Goals");
        _fileName = GetFileName();
 
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"TotalPoints:{_totalPoints}");
 
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.CreateStringForFileSave());
            }
        }
    }
 
    public void LoadFromFile()
    {
        Console.Clear();
        Console.WriteLine("Load Goals");
        _fileName = GetFileName();
 
        if (File.Exists(_fileName))
        {
            _goals.Clear();
            string[] fileAsList = System.IO.File.ReadAllLines(_fileName);
 
            foreach (string line in fileAsList)
            {
                CreateGoalFromString(line);
            }
        }
        else
        {
            Console.WriteLine("Invalid file name.");
            Console.Write("Press enter to return to the main menu.");
            Console.ReadLine();
        }
    }
 
    private void CreateGoalFromString(string line)
    {
        string[] splitList = line.Split(":");
        string goalType = splitList[0];
        string goalString = splitList[1];
 
        if (goalType == "TotalPoints")
        {
            _totalPoints = int.Parse(goalString);
        }
        else
        {
            if (goalType == "SimpleGoal") 
            {
                SimpleGoal goal = new SimpleGoal(goalString);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal") 
            {
                EternalGoal goal = new EternalGoal(goalString);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal") 
            {
                ChecklistGoal goal = new ChecklistGoal(goalString);
                _goals.Add(goal);
            }
        }
    }

    public void RecordingEvents(int userSelection)
    {
        int goalsCount = _goals.Count();
        if (userSelection <= goalsCount && userSelection > 0)
        {
            int index = userSelection - 1;
            _totalPoints += _goals[index].RecordEvent();
        }
    }
}