public abstract class Menu
{
    //Attributes
    protected int _userSelection;
    protected string _prompt;
 
    //Methods
    public abstract void DisplayMenu();
 
    public int GetUserSelection()
    {
        Console.Write(_prompt);
        int userSelection = int.Parse(Console.ReadLine());
        Console.WriteLine();
        return userSelection;
    }
}