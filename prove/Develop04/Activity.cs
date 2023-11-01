
class Activity
{
    //Attributes
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected DateTime _startTime;
    protected DateTime _endTime;

    protected int _activityDuration;
    
    private DateTime _spinnerStartTime;
    private DateTime _spinnerEndTime;

    // Methods
    protected void DisplayIntro()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        DisplaySpinner("Get ready... ", 5);
    }

    protected void DisplayClosing()
    {
        DisplaySpinner("Well done!! ", 3);
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        DisplaySpinner("", 5);
    }
    
    protected void DisplaySpinner(string message, int duration)
    {
        _spinnerStartTime = DateTime.Now;
        _spinnerEndTime = _spinnerStartTime.AddSeconds(duration);

        string[] spinnerSymbols = {"|", "/", "-", "\\"};

        Console.Write(message);

        while (DateTime.Now < _spinnerEndTime)
        {
            foreach (string symbol in spinnerSymbols)
            {
                Console.Write(symbol);
                Thread.Sleep(600);
                Console.Write("\b \b");
            }
        }
        Console.Write("|");
        Thread.Sleep(200);
        Console.Write("\b \b");
        Console.WriteLine();
    }

    protected void DisplayCountdownTimer(string message, int countdown)
    {
        Console.Write(message);

        for (int i = countdown; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 
        Console.WriteLine();
    }
}