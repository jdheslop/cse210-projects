/*
Derived Class: WritingAssignment - Base: ASSIGNMENT
    Attributes:
        ASSIGNMENT: private string _studentName;
        ASSIGNMENT: private string _topic;
        private string _assignmentTitle;

        A writing assignment may need to store the student's name, the topic (for example, "European History"), and the title of the assignment (for example, "The Causes of World War II").

    Constructors:
        WritingAssignment(string studentName, string topic, string assignmentTitle) : base(studentName, topic)

        The writing assignment should have a constructor that requires a value for each of the items that it stores.

    Getters / Setters:
    Methods:
        ASSIGNMENT: AssignmentSummary()
            _studentName, _topic
        public string WritingInformation()
            _assignmentTitle, _studentName

        The writing assignment needs to provide a method to return a summary of the assignment that contains the student's name and the topic, and it also needs to provide a method to get the writing information which consists of the title and the student's name (for example, "The Causes of World War II by Mary Waters").
*/

using System;

public class WritingAssignment : Assignment
{
    //Attributes:
        private string _assignmentTitle;

    //Constructors:
        public WritingAssignment(string studentName, string topic, string assignmentTitle) : base(studentName, topic)
        {
            _assignmentTitle = assignmentTitle;
        }

    //Methods:
    public string WritingInformation()
    {
        return $"{_assignmentTitle} by {GetStudentName()}"; 
    }
}
