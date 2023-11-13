
public class EternalGoal : Goal
{
    //Constructors
    public EternalGoal()
    {
        _goalType = "EternalGoal";
        _isComplete = false;
    }
    public EternalGoal(string goalString)
    {
        string[] parts = goalString.Split("|");
        _goalType = "EternalGoal";
        _goalName = parts[0];
        _goalDescription = parts[1];
        _goalPoints = int.Parse(parts[2]);
        _isComplete = false;    
    }
    //Methods    
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }
    
    public override int RecordEvent()
    {
        return _goalPoints;
    }
    
    public override string CreateStringForFileSave()
    {
        return $"{_goalType}:{_goalName}|{_goalDescription}|{_goalPoints}";
    }
}

