/*
Derived Class: ReflectingActivity : Activity
    //Attributes
        private List<string> _reflectingPromptList = new List<string>();
        private PromptList _reflectingPrompts;
        private string _reflectingPrompt;
        
        private List<string> _reflectingQuestionList = new List<string>();
        private PromptList _reflectingQuestions;
        private string _question;
    //Constructors
        ReflectingActivity()
    //Methods
        private string CreateReflectingPrompt(PromptList prompts)
        private void DisplayPrompt()
        public void RunReflectingActivity()

*/

class ReflectingActivity : Activity
{
    //Attributes
    private List<string> _reflectingPromptList = new List<string>();
    private PromptList _reflectingPrompts;
    private string _reflectingPrompt;
    
    private List<string> _reflectingQuestionList = new List<string>();
    private PromptList _reflectingQuestions;
    private string _question;

    //Constructors
    public ReflectingActivity()
    {
        _activityName = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _reflectingPromptList.Add("Think of a time when you stood up for someone else.");
        _reflectingPromptList.Add("Think of a time when you did something really difficult.");
        _reflectingPromptList.Add("Think of a time when you helped someone in need.");
        _reflectingPromptList.Add("Think of a time when you did something truly selfless.");

        _reflectingPrompts = new PromptList(_reflectingPromptList);

        _reflectingQuestionList.Add("Why was this experience meaningful to you?");
        _reflectingQuestionList.Add("Have you ever done anything like this before?");
        _reflectingQuestionList.Add("How did you get started?");
        _reflectingQuestionList.Add("How did you feel when it was complete?");
        _reflectingQuestionList.Add("What made this time different than other times when you were not as successful?");
        _reflectingQuestionList.Add("What is your favorite thing about this experience?");
        _reflectingQuestionList.Add("What could you learn from this experience that applies to other situations?");
        _reflectingQuestionList.Add("What did you learn about yourself through this experience?");
        _reflectingQuestionList.Add("How can you keep this experience in mind in the future?");

        _reflectingQuestions = new PromptList(_reflectingQuestionList);
    }

    // Methods
    public void RunReflectingActivity()
    {
        DisplayIntro();
        Console.Clear();
        
        _reflectingPrompt = CreateReflectingPrompt(_reflectingPrompts);
        DisplayPrompt(_reflectingPrompt);
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        DisplayCountdownTimer("The activity begins in: ", 5);

        Console.Clear();
        DisplayPrompt(_reflectingPrompt);
        Console.WriteLine();

        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
        
        while (DateTime.Now < _endTime)
        {
            _question = CreateReflectingPrompt(_reflectingQuestions);
            Console.Write($"> {_question} ");
            DisplaySpinner("", 8);
            Console.WriteLine();
        }

        TimeSpan timeDifference = DateTime.Now - _startTime;
        _activityDuration = (int)timeDifference.TotalSeconds;
        DisplayClosing();
    }

    private string CreateReflectingPrompt(PromptList prompts)
    {
        return prompts.GetPrompt();
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
    }
}