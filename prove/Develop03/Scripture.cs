using System;

/*
Class: Scripture
Attributes:
    _words : List<Word>
_reference : Reference
    _allHidden : bool
Constructors:
    Scripture(Reference reference, string scriptureText)
Getters  / Setters:
    GetAllHidden() : bool
Methods:
    DisplayScripture() : void
    CheckHiddenStatus() : bool
    HideWords() : void
*/
 
public class Scripture
{
    //Attributes
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private bool _allHidden;
 
    // Constructors
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _allHidden = false;
 
        string[] scriptureWords = scriptureText.Split(“ “);
 
        foreach (scriptureWord in scriptureWords)
        {
            Word wordForList = new Word(scriptureWord);
             _words.Add(wordForList);
### NEXT STEP IS TO CREATE THE WORD CLASS
        }
    }
 
 
}
