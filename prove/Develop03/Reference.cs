/*
Class: Reference
Attributes:
        _reference : string
        _book : string
        _chapter : string
        _verse : string
        _endingVerse : string
Constructors:
        Reference(string selectedScripture)
Getters  / Setters:
        GetReference() : string
Methods:
*/
 
public class Reference
    {
        // Attributes
        private string _reference;
        private string _book;
        private string _chapter;
        private string _verse;
        private string _endingVerse;
    
        // Constructors
        public Reference(string selectedScripture)
        {
            string[] referenceItems = selectedScripture.Split("|");
            _book = referenceItems[0];
            _chapter = referenceItems[1];
            _verse = referenceItems[2];
            _endingVerse = referenceItems[3];

            if (_endingVerse == "")
            {
                _reference = $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                _reference = $"{_book} {_chapter}:{_verse}-{_endingVerse}";
            }
        }
    
        // Getters / Setters
        public string GetReference()
        {
            return _reference;
        }
    }
 
