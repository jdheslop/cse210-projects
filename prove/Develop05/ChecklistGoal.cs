
public class ChecklistGoal : Goal
{
    //Attributes
    private int _goalBonus;
    private int _goalQuantity;
    private int _completedQuantity;

    //Constructors
    public ChecklistGoal()
    {
        _goalType = "ChecklistGoal";
        _isComplete = false;
    }
    public ChecklistGoal(string goalString)
    {
        string[] parts = goalString.Split("|");
        _goalType = "ChecklistGoal";
        _goalName = parts[0];
        _goalDescription = parts[1];
        _goalPoints = int.Parse(parts[2]);
        _goalBonus = int.Parse(parts[3]);
        _goalQuantity = int.Parse(parts[4]);
        _completedQuantity = int.Parse(parts[5]);

        if (_completedQuantity < _goalQuantity)
        {
            _isComplete = false;
        }
        else
        {
            _isComplete = true;
        }

    }
    //Methods
    public void CreateChecklistGoal()
    {
        CreateNewGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalQuantity = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _goalBonus = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }
				
    public override void DisplayGoal()
    {
        string status = "[ ]";
        if (_isComplete == true)
        {
            status = "[X]";
        }
        Console.WriteLine($"{status} {_goalName} ({_goalDescription}) -- Currently completed: {_completedQuantity} / {_goalQuantity}");
    }
    
    protected override void RecordEvent()
    {
        Console.WriteLine();
        //STILL NEED TO DO THIS
    }
    
    public override string CreateStringForFileSave()
    {
        return $"{_goalType}:{_goalName}|{_goalDescription}|{_goalPoints}|{_goalBonus}|{_goalQuantity}|{_completedQuantity}";;
    }

    public override void CreateGoalFromString()
    {
        Console.WriteLine();
        //STILL NEED TO DO THIS
    }
}

