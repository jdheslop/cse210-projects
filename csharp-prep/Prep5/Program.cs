using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(); 

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName, numberSquared);
    
        Console.WriteLine();
    }

    static void DisplayWelcome() 
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;  
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number; 
        return numberSquared;
    }

    static void DisplayResult(string name, int numberSquared)
    {
        Console.WriteLine($"{name}, the square of your number is {numberSquared}");
    }
}