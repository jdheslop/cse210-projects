
class PromptList
{
    //Attributes
    private List<Prompt> _prompts = new List<Prompt>();
    private string _prompt;

    //Constructors
    public PromptList(List<string> prompts)
    {
        foreach (string prompt in prompts)
        {
            Prompt promptForList = new Prompt(prompt);
            _prompts.Add(promptForList);
        }
    }

    // Methods
    private void CheckAllAvailabilty()
    {
        bool availableStatus = false;
        foreach (Prompt prompt in _prompts)
        {
            if (prompt.GetPromptAvailability() == true)
            {
                availableStatus = true;
            }
        }
        if (availableStatus == false)
        {
            foreach (Prompt prompt in _prompts)
            {
                prompt.SetPromptAvailability(true);
            }
        } 
    }

    public string GetPrompt()
    {
        CheckAllAvailabilty();

        bool promptSelected = false;

        while (promptSelected == false)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _prompts.Count);
            bool displayStatus = _prompts[randomIndex].GetPromptAvailability();

            if (displayStatus == true)
            {
                _prompt = _prompts[randomIndex].GetPromptText();
                _prompts[randomIndex].SetPromptAvailability(false);
                promptSelected = true;
            }
        }
        return _prompt;
    }
}

