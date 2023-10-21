using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.AssignmentSummary());
        Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.AssignmentSummary());
        Console.WriteLine(mathAssignment1.MathHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.AssignmentSummary());
        Console.WriteLine(writingAssignment1.WritingInformation());
        Console.WriteLine();
    }
}