public class MainMenu : Menu
{
    //Constructor
    public MainMenu()
    {
        _userSelection = -1;
        _prompt = "Select a choice from the menu: ";
    }
 
    //Methods
    public void DisplayTotalPoints(int totalPoints)
    {
        Console.Clear();
        Console.WriteLine($"You have {totalPoints} points.");
        Console.WriteLine();
    }
    
    public override void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Open Goals");
        Console.WriteLine("  3. List Completed Goals");
        Console.WriteLine("  4. Save Goals");
        Console.WriteLine("  5. Load Goals");
        Console.WriteLine("  6. Record Event");
        Console.WriteLine("  Enter 0 to quit.");
    }
}
