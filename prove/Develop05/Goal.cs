
public abstract class Goal
{
    //Attributes
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool _isComplete;

    //Getters & Setters
    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool status)
    {
        _isComplete = status;
    }
    
    public string GetGoalName()
    {
        return _goalName;
    }

    //Methods
    public void CreateNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    public abstract void DisplayGoal();
    protected abstract void RecordEvent();
    public abstract string CreateStringForFileSave();
    public abstract void CreateGoalFromString();
}

    
