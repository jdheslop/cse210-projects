
public class SimpleGoal : Goal
{
    //Constructors
    public SimpleGoal()
    {
        _goalType = "SimpleGoal";
        _isComplete = false;
    }
    public SimpleGoal(string goalString)
    {
        string[] parts = goalString.Split("|");
        _goalType = "SimpleGoal";
        _goalName = parts[0];
        _goalDescription = parts[1];
        _goalPoints = int.Parse(parts[2]);
        _isComplete = Convert.ToBoolean(parts[3]);
    }
    
    //Methods    
    public override void DisplayGoal()
    {
        string status = "[ ]";

        if (_isComplete == true)
        {
            status = "[X]";
        }
                
        Console.WriteLine($"{status} {_goalName} ({_goalDescription})");
    }
    
    protected override void RecordEvent()
    {
        Console.WriteLine();
        //STILL NEED TO DO THIS
    }
    
    public override string CreateStringForFileSave()
    {
        return $"{_goalType}:{_goalName}|{_goalDescription}|{_goalPoints}|{_isComplete}";
    }

    public override void CreateGoalFromString()
    {
        Console.WriteLine();
        //STILL NEED TO DO THIS
    }
}

