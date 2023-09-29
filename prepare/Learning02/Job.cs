using System;

/*
Class: Job
Attributes:
_company : string
_jobTitle :  string
_startYear : int
_endYear : int
Methods:
DisplayJobInformation() : void
    "Job Title (Company) StartYear-EndYear"
*/

public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void DisplayJobInformation()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
}