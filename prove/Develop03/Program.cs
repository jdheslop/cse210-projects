/*
Exceeding Requirements:
    - When randomly selecting words to hide, it only selects from those words that are not already hidden.
    - Load scriptures from a files and randomly select a verse.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        FileWithScriptures file1 = new FileWithScriptures("scriptures.txt");
        string scriptureText1 = file1.GetScriptureText();
        
        Reference referenceObject1 = new Reference(file1.GetSelectedScripture());
        string reference1 = referenceObject1.GetReference();
        
        Scripture scripture1 = new Scripture(reference1, scriptureText1);
        scripture1.DisplayScripture();
    }
}