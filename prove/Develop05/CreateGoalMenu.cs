public class CreateGoalMenu : Menu
{
    //Constructor
    public CreateGoalMenu()
    {
        _userSelection = 0;
        _prompt = "Which type of Goal would you like to create? ";
    }
 
    //Methods
    public override void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }
}
