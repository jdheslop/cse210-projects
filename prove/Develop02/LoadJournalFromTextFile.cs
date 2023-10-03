
/*
Class: LoadJournalFromTextFile
Attributes:
    _fileName : string
Methods:
    LoadFromTextFile(list) : void
*/

using System;
using System.IO;

public class LoadJournalFromTextFile
    {
        public string _fileName;

        public void LoadFromTextFile(List<Entry> list)
        {
            if (File.Exists(_fileName))
            {
                list.Clear();
                string[] fileAsList = System.IO.File.ReadAllLines(_fileName);

                foreach (string line in fileAsList)
                {
                    string[] items = line.Split("|");

                    Entry newEntry = new Entry();
                    newEntry._date = items[0];
                    newEntry._prompt = items[1];
                    newEntry._entryInput = items[2];

                    list.Add(newEntry);
                }
            }
            else
            {
                Console.WriteLine("Invalid file name.");
            }
        }

    }