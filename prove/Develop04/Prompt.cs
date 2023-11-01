
class Prompt
{
    //Attributes
    private string _promptText;
    private bool _promptAvailable;

    //Constructors
    public Prompt(string promptText)
    {
        _promptText = promptText;
        _promptAvailable = true;
    }

    // Methods
    public string GetPromptText()
    {
        return _promptText;
    }
    public bool GetPromptAvailability()
    {
        return _promptAvailable;
    }
    public void SetPromptAvailability(bool available)
    {
        _promptAvailable = available;
    }
}