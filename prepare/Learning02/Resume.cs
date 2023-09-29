
/*
Class: Resume
Attributes:
_name : string
_jobs : List<Job>
Methods:
DisplayResume() : void
    Displays the resume, which shows the name first, followed by displaying each one of the jobs
*/

using System

public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        public void DisplayResume()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            foreach (Job j in _jobs)
            {
                j.DisplayJobInformation();
            }

            Console.WriteLine();
        }
    }
