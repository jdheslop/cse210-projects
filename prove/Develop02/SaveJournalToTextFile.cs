
/*
Class: SaveListToTextFile
Attributes:
    _fileName : string
Methods:
    WriteToTextFile(List<string> list) : void 
*/

using System;
using System.IO;

public class SaveJournalToTextFile
    {

        public string _fileName;

        public void WriteToTextFile(List<Entry> list)
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                foreach (Entry entry in list)
                {
                    outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entryInput}");
                }
            }
        }
    }