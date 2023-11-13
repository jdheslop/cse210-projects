
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

    public SimpleGoal(int random)
    {
        _goalType = "SimpleGoal";
        _goalDescription = "Random";
        _isComplete = false;
        _goalPoints = random;

        List<string> randomGoals = new List<string>();
        randomGoals.Add("Visit the temple");
        randomGoals.Add("Read scriptures");
        randomGoals.Add("Say morning prayers");
        randomGoals.Add("Say evening prayers");
        randomGoals.Add("Go jogging");
        randomGoals.Add("Plant a tree");
        randomGoals.Add("Say something kind to someone");

        Random random1 = new Random();
        int randomIndex = random1.Next(0, randomGoals.Count);
        _goalName = randomGoals[randomIndex];
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
    
    public override int RecordEvent()
    {
        _isComplete = true;
        return _goalPoints;
    }
    
    public override string CreateStringForFileSave()
    {
        return $"{_goalType}:{_goalName}|{_goalDescription}|{_goalPoints}|{_isComplete}";
    }
}

