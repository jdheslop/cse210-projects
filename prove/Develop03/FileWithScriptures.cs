
/*
Class: FileWithScriptures
Attributes:
    _selectedScripture : string
    _fileAsList : List<string>
    _fileName : string
    _scriptureText : string
Constructor:
    FileWithScriptures(string fileName)
Getters / Setters:
    GetSelectedScripture() : string
    GetScriptureText() : string
Methods:
    ConvertFileToList() : void
    GenerateScriptureText() : void
*/

using System;
using System.IO;

public class FileWithScriptures
{
    //Attributes
    private string _fileName;
    private List<string> _fileAsList = new List<string>();
    private string _selectedScripture;
    private string _scriptureText;

    //Constructors
    public FileWithScriptures(string fileName)
    {
        _fileName = fileName;
        
        // Create _fileAsList
        ConvertFileToList();
        
        Random random = new Random();
        _selectedScripture = _fileAsList[random.Next(0, _fileAsList.Count)];

        // Creates the the scripture text for the selected scripture
        GenerateScriptureText();
    }

    //Getters / Setters
    public string GetScriptureText()
    {
        return _scriptureText;
    }
    public string GetSelectedScripture()
    {
        return _selectedScripture;
    }

    // Methods
    private void ConvertFileToList()
    {
        string[] fileAsList = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in fileAsList)
        {
            _fileAsList.Add(line);
        }
    }
    public void GenerateScriptureText()
    {
        string[] referenceItems = _selectedScripture.Split("|");
        _scriptureText = referenceItems[4];
    }
}



