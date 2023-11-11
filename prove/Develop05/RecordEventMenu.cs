public class RecordEventMenu : Menu
{
    //Constructor
    public RecordEventMenu()
    {
        _userSelection = 0;
        _prompt = "Which goal did you accomplish? ";
    }
 
    //Methods
    public override void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("The goals are: ");
 
        goalOverview.DisplayItemsForRecordEventMenu();
    }
 
    private void DisplayTotalPoints()
    {
        Console.WriteLine($"You now have {goalOverview.GetTotalPoints()}");
        Console.WriteLine();
    }
}