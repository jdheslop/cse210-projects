/*
Class: Word
Attributes:
        _word : string
        _removedWord : string
        _display : bool
Constructors:
        Word(string word) :  Preassign _display to “true” (do this in the Constructor: createRemovedWord() : string)
Getters  / Setters:
        GetDisplay()
        SetDisplay()
Methods:
        DisplayWord() : void
*/
 
using System;
 
public class Word
    {
        //Attributes
        private string _word;
        private string _removedWord;
        private bool _display;
 
        // Constructors
        public Word(string word)
        {
            _word = word;
            _removedWord = new string('_', word.Length);
            _display = true;
        }
 
        //Getters / Setters
        public bool GetDisplay()
        {
            return _display;
        }
        public void SetDisplay(bool display)
        {
            _display = display;
        }
 
        //Methods
        public void DisplayWord()
        {
            if (_display == true)
            {
                Console.Write(_word);
            }
            else
            {
                Console.Write(_removedWord);
            }
        }
    }

