/*
Class: Reference
Attributes:
        _reference : string
Constructors:
        Reference(string book, string chapter, string verse) : For single verse references. Combine the attributes to create _reference.
        Reference(string book, string chapter, string verse, string endingVerse) : For multiple verse references. Combine the attributes to create _reference.
Getters  / Setters:
        GetReference() : string
Methods:
*/
 
public class Reference
    {
    // Attributes
    private string _reference;
 
    // Constructors
    public Reference(string book, string chapter, string verse)
    {
        _reference = $”{book} {chapter}:{verse}”;
    }
 
    public Reference(string book, string chapter, string verse, string endingVerse)
    {
        _reference = $”{book} {chapter}:{verse}-{endingVerse}”;
    }
 
    // Getters / Setters
    public string GetReference()
    {
        return _reference;
    }
 
