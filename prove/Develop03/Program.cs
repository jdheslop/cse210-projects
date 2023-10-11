using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        string scriptureText1 = "And it came to pass.";
 
        Reference referenceObject1 = new Reference("1 Nephi", "3", "7");
        string reference1 = referenceObject1.GetReference();
        
        Scripture scripture1 = new Scripture(reference1, scriptureText1);

    }
}