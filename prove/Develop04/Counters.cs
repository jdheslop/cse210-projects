
class Counters
{
    //Attributes
    private int _breathingCounter;
    private int _reflectingCounter;
    private int _listingCounter;

    //Constructors
    public Counters()
    {
        _breathingCounter = 0;
        _reflectingCounter = 0;
        _listingCounter = 0;
    }

    // Methods
    public void increaseBreathingCounter()
    {
        _breathingCounter += 1;
    }

    public void increaseReflectingCounter()
    {
        _reflectingCounter += 1;
    }

    public void increaseListingCounter()
    {
        _listingCounter += 1;
    }

    public void DisplayCounters()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Number of times the Breathing Activity has been completed: {_breathingCounter}");
        Console.WriteLine($"Number of times the Reflecting Activity has been completed: {_reflectingCounter}");
        Console.WriteLine($"Number of times the Listing Activity has been completed: {_listingCounter}");
        Console.WriteLine();
        
        Console.Write("Press enter to return to the menu. ");
        Console.ReadLine();
    }


}