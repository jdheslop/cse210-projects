public class MainMenu : Menu
{
    //Constructor
    public MainMenu()
    {
        _userSelection = 0;
        _prompt = "Select a choice from the menu: ";
    }
 
    //Methods
    public override void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine($"You have {goalOverview.GetTotalPoints()} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Open Goals");
        Console.WriteLine("  3. List Completed Goals");
        Console.WriteLine("  4. Save Goals");
        Console.WriteLine("  5. Load Goals");
        Console.WriteLine("  6. Record Event");
        Console.WriteLine("  9. Quit");
    }
}
