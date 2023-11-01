/*
Derived Class: BreathingActivity : Activity
    //Attributes
        None
    //Constructors
        BreathingActivity()
    //Methods
        public void RunBreathingActivity()
*/

class BreathingActivity : Activity
{
    //Attributes
        // None

    //Constructors
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Methods
    public void RunBreathingActivity()
    {   
        DisplayIntro();
        Console.Clear();
        Console.WriteLine();

        _activityDuration = 0;
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
        
        while (DateTime.Now < _endTime)
        {
            DisplayCountdownTimer("Breath in... ", 4);
            DisplayCountdownTimer("Now breathe out... ", 6);
            _activityDuration += 10;
            Console.WriteLine();
        }
        
        TimeSpan timeDifference = DateTime.Now - _startTime;
        _activityDuration = (int)timeDifference.TotalSeconds;
        DisplayClosing();
    }
}