
/*
Class: Entry
Attributes:
    _date : string
    _prompt : string
    _entryInput : string
Methods:
    DisplayEntry() : void
    GenerateDate() : string
*/

using System;

public class Entry
    {
        public string _date;
        public string _prompt;
        public string _entryInput; 

        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
            Console.WriteLine(_entryInput);
        }

        public string GenerateDate()
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDate = currentDateTime.ToString("dd MMMM yyyy");
            return formattedDate;
        }
    }
