using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Console.Write("Please enter your grade percentage: ");
        string gradePercentageInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageInput);

        int gradeLastDigit = gradePercentageInput[gradePercentageInput.Length - 1];

        string letterGrade = "";
        string gradeSign = "";
        string gradeResult = "";

        if (gradeLastDigit >= 7)
        {
            gradeSign = "+";
        }
        else if (gradeLastDigit < 3)
        {
            gradeSign = "-";
        }

        if (gradePercentage >= 90)
        {
            if (gradeLastDigit < 3)
            {
                letterGrade = $"A{gradeSign}";
            }
            else
            {
                letterGrade = "A";
            }
        } 
        else if (gradePercentage >= 80)
        {
            letterGrade = $"B{gradeSign}";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = $"C{gradeSign}";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = $"D{gradeSign}";
        }
        else 
        {
            letterGrade = "F";
        }

        if (gradePercentage >= 70)
        {
            gradeResult = "Congratulations! You passed!";
        }
        else 
        {
            gradeResult = "You'll get it next time!";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");
        Console.WriteLine(gradeResult);

        Console.WriteLine();
    }
}