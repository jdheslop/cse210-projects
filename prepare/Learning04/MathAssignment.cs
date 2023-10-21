
/*
Derived Class: MathAssignment - Base: Assignment
    Attributes:
        ASSIGNMENT: private string _studentName;
        ASSIGNMENT: private string _topic;
        private string _textbookSection;
        private string _sectionProblems;

    Constructors:   
        MathAssignment(string studentName, string topic, string textbookSection, string sectionProblems) : base(studentName, topic)

    Getters / Setters:
    Methods:
        ASSIGNMENT: AssignmentSummary()
            _studentName, _topic
        public string MathHomeworkList()
            _textbookSection, _sectionProblems
*/

using System;

public class MathAssignment : Assignment
{
        //Attributes:
        private string _textbookSection;
        private string _sectionProblems;

        //Constructors:   
        public MathAssignment(string studentName, string topic, string textbookSection, string sectionProblems) : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _sectionProblems = sectionProblems;
        }

        //Methods:
        public string MathHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_sectionProblems}";
        }

}