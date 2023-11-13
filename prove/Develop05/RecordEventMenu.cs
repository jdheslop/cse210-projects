public class RecordEventMenu : Menu
{
    //Attributes
    List<string> _recordEventItems = new List<string>();

    //Constructor
    public RecordEventMenu(List<Goal> goals)
    {
        _userSelection = -1;
        _prompt = "Which goal did you accomplish? ";
        ItemsForRecordEventMenu(goals);
    }
 
    //Methods
    public override void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("The goals are: ");

        foreach (string item in _recordEventItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Enter 0 to cancel.");
    }

    public void DisplayTotalPoints(int totalPoints)
    {
        Console.WriteLine($"You now have {totalPoints} total points.");
        Console.WriteLine();
        Console.Write("Press enter to return to the main menu.");
        Console.ReadLine();
    }
 
    private void ItemsForRecordEventMenu(List<Goal> goals)
    {
        int counter = 1;
        foreach (Goal goal in goals)
        {
            if (goal.GetIsComplete() == false)
            {
                _recordEventItems.Add($"{counter}. {goal.GetGoalName()}");
                counter += 1;
            }
        }
    }
}