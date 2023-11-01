/*
Exceeds Requirements
- Make sure no random prompts/questions are selected until they have all been used at least once in that session.
- Keep a log of how many times activities were performed.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Counters counters = new Counters();

        Menu programMenu = new Menu();
        int userInput = 0;

        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        while (userInput != 5) 
        {
            userInput = programMenu.DisplayMenu();

            if (userInput == 1)
            {
                breathing.RunBreathingActivity();
                counters.increaseBreathingCounter();
            }
            else if (userInput == 2)
            {
                reflecting.RunReflectingActivity();
                counters.increaseReflectingCounter();
            }
            else if (userInput == 3)
            {
                listing.RunListingActivity();
                counters.increaseListingCounter();
            }
            else if (userInput == 4)
            {
                counters.DisplayCounters();
            }
            else if (userInput == 5)
            {
                Console.WriteLine("Goodbye");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
                Thread.Sleep(3000);
                Console.WriteLine();
            }
        }
    }
}