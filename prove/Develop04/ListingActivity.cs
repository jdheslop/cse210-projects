
class ListingActivity : Activity
{
    //Attributes
        private List<string> _listingPromptList = new List<string>();
        private PromptList _listingPrompts;
        private string _listingPrompt;
        private int _counter;

    //Constructors
    public ListingActivity()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _counter = 0;

        _listingPromptList.Add("Who are people that you appreciate?");
        _listingPromptList.Add("What are personal strengths of yours?");
        _listingPromptList.Add("Who are people that you have helped this week?");
        _listingPromptList.Add("When have you felt the Holy Ghost this month?");
        _listingPromptList.Add("Who are some of your personal heroes?");

        _listingPrompts = new PromptList(_listingPromptList);
    }

    // Methods
    public void RunListingActivity()
    {
        DisplayIntro();
        Console.Clear();
        
        _listingPrompt = CreateListingPrompt(_listingPrompts);
        DisplayPrompt(_listingPrompt);
        Console.WriteLine();
        DisplayCountdownTimer("The activity begins in: ", 5);

        Console.Clear();
        DisplayPrompt(_listingPrompt);
        Console.WriteLine();

        _activityDuration = 0;
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
        
        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _counter += 1;
        }

        TimeSpan timeDifference = DateTime.Now - _startTime;
        _activityDuration = (int)timeDifference.TotalSeconds;
        Console.WriteLine();
        Console.WriteLine($"You listed {_counter} items!");
        DisplayClosing();
    }

    private string CreateListingPrompt(PromptList prompts)
    {
        return prompts.GetPrompt();
    }
    
    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
    }
}