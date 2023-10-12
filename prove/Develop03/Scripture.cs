
/*
Class: Scripture
Attributes:
    _words : List<Word>
_reference : Reference
    _allHidden : bool
Constructors:
    Scripture(string reference, string scriptureText)
Getters  / Setters:
Methods:
    DisplayScripture() : void
    CheckHiddenStatus() : bool
    HideWords() : void
*/
 
using System;
 
public class Scripture
    {
        //Attributes
        private List<Word> _words = new List<Word>();
        private string _reference;
        private bool _allHidden;
 
        // Constructors
        public Scripture(string reference, string scriptureText)
        {
            _reference = reference;
            _allHidden = false;
 
            string[] scriptureWords = scriptureText.Split(" ");
 
            foreach (scriptureWord in scriptureWords)
            {
                Word wordForList = new Word(scriptureWord);
                _words.Add(wordForList);    
            }
        }
 
        //Getters and Setters
 
        //Methods
        public void DisplayScripture()
        {
            while (_allHidden == false)
            {
                //NEED TO ADD PROGRAM TO CLEAR THE SCREEN
 
                Console.Write($"{_reference} - ");
 
                foreach (scriptureWord in _words)
                {
                    scriptureWord.DisplayWord();
                    Console.Write(" ");
                }
 
                Console.WriteLine();
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                string userInput = Console.ReadLine();
 
                if (userInput == "quit")
                {
                    _allHidden = true;
                }
                else
                {
                    _allHidden = CheckHiddenStatus()
                    // ADD HIDEWORDS METHOD
                }
            }
        }
 
        private bool CheckHiddenStatus()
        {
            bool allHiddenStatus = true;
 
            foreach (scriptureWord in _words)
            {
                wordDisplayStatus = scriptureWord.GetDisplay();
                if (wordDisplayStatus == true)
                {
                    allHiddenStatus = false;
                }
 
                return allHiddenStatus;
            }
        }
 
 
        // WRITE HIDEWORDS() METHOD - this can also be private
 
 
 
}

