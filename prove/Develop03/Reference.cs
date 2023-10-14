/*
Class: Reference
Attributes:
        _reference : string
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
    
        // Constructors
        public Reference(string selectedScripture)
        {
            string[] referenceItems = selectedScripture.Split("|");
            string book = referenceItems[0];
            string chapter = referenceItems[1];
            string verse = referenceItems[2];
            string endingVerse = referenceItems[3];

            if (endingVerse == "")
            {
                _reference = $"{book} {chapter}:{verse}";
            }
            else
            {
                _reference = $"{book} {chapter}:{verse}-{endingVerse}";
            }
        }
    
        // Getters / Setters
        public string GetReference()
        {
            return _reference;
        }
    }
 
