/*
Base Class: Assignment
    Attributes:
        private string _studentName;
        private string _topic;
    Constructors:
        Assignment(string studentName, string topic)
    Getters / Setters:
        public string GetStudentName()
            For Derived Class: WritingAssignment 
    Methods:
        public string AssignmentSummary()
            _studentName, _topic
*/

using System;

public class Assignment
{
    //Attributes
    private string _studentName;
    private string _topic;
    
    //Constructors
    public Assignment(string studentName, string topic) 
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Getters / Setters
    public string GetStudentName()
    {
        return _studentName;
    }

    //Methods
    public string AssignmentSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
        

}
