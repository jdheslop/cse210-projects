public class MainMenu
{
    //Attributes
    protected int _userSelection;

    //Constructor
    public MainMenu()
    {
        _userSelection = -1;
    }

    //Methods
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create a New To Do Item");
        Console.WriteLine("  2. Display Open To Do Items");
        Console.WriteLine("  3. Create a New Person");
        Console.WriteLine("  4. Create a New Item to Discuss with Someone");
        Console.WriteLine("  5. Display Items to Discuss");
        Console.WriteLine("  6. Create a New Meeting");
        Console.WriteLine("  7. Display Notes from a Meeting");
        Console.WriteLine("  8. Save Data to File");
        Console.WriteLine("  9. Load Data from File");
        Console.WriteLine("  Enter 0 to quit.");
    }
 
    public int GetUserSelection()
    {
        Console.Write("Select a choice from the menu: ");
        int userSelection = int.Parse(Console.ReadLine());
        Console.WriteLine();
        return userSelection;
    }
}