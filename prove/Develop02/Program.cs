// Jackson Heslop
/*
Exceeding Requirements:
- Seven classes in addition to the Program class
    - Menu: Displays the menu and then returns the user selection
    - Journal: Stores the entries to a list and displays all entries
    - Entry: Stories the entry data
    - PromptGenerator: Generates a prompt for the entry
    - UserInputAsString: Gets the file name from the user for the save and load classes
    - SaveJournalToTextFile
    - LoadJournalFromTextFile
- Think of other problems that keep people from writing in their journal and address one of those.
    - Provided the user an option to have a journal entry without a question as a prompt.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        //Instantiate classes and define attributes
        Menu menu1 = new Menu();
        menu1._menuIntro = "Please select one of the following choices:";
        menu1._menuItems.Add("1. Write a new entry using a prompt");
        menu1._menuItems.Add("2. Write a new entry without a prompt");
        menu1._menuItems.Add("3. Display the journal");
        menu1._menuItems.Add("4. Save the journal to a file");
        menu1._menuItems.Add("5. Load the journal from a file");
        menu1._menuQuit = "6. Quit the program";
        menu1._menuClosing = "What would you like to do: ";

        Journal journal1 = new Journal();

        PromptGenerator prompt1 = new PromptGenerator();
        prompt1._prompts.Add("What is something that you were happy about?");
        prompt1._prompts.Add("What is something that you were sad about?");
        prompt1._prompts.Add("What do you look forward to tomorrow?");
        prompt1._prompts.Add("What were you thankful for today?");
        prompt1._prompts.Add("How did you see the hand of God in your life?");

        UserInputAsString inputFileName = new UserInputAsString();
        inputFileName._inputPrompt = "What is the file name?";

        SaveJournalToTextFile saveToFile = new SaveJournalToTextFile();
        LoadJournalFromTextFile loadFromFile = new LoadJournalFromTextFile();


        // Define variables
        bool repeat = true;


        // Run program
        while (repeat == true)
        {

            int userSelection = menu1.DisplayMenu(); 
        
            if (userSelection == 1)
            {
                string prompt = prompt1.GeneratePrompt();                
                journal1.AddEntry(prompt);
            }
            else if (userSelection == 2)
            {
                string prompt = "Please write whatever you would like.";                
                journal1.AddEntry(prompt);
            }
            else if (userSelection == 3)
            {
                journal1.DisplayAllEntries();
            }
            else if (userSelection == 4)
            {
                saveToFile._fileName = inputFileName.GetUserInputAsString();
                saveToFile.WriteToTextFile(journal1._entries);
            }
            else if (userSelection == 5)
            {
                loadFromFile._fileName = inputFileName.GetUserInputAsString();
                loadFromFile.LoadFromTextFile(journal1._entries);
            }
            else if (userSelection == 6)
            {
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
                repeat = false;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again.");
            }
        }
    }
}
