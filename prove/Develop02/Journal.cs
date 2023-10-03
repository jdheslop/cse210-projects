
/*
Class: Journal
Attributes:
    _entries : List<Entry>
Methods:
    AddEntry(promptList) : void
    DisplayAllEntries() : void
*/

using System;

public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(string prompt)
        {
            Entry newEntry = new Entry();

            newEntry._prompt = prompt;
            
            Console.WriteLine(prompt);
            Console.Write("> ");
            newEntry._entryInput = Console.ReadLine();

            newEntry._date = newEntry.GenerateDate();

            _entries.Add(newEntry);
        }

        public void DisplayAllEntries()
        {
            Console.WriteLine();
            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
                Console.WriteLine();
            }
        }
    }
