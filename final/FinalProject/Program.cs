using System;

class Program
{
    static void Main(string[] args)
    {
        MainMenu mainMenu = new MainMenu();
        OverviewMyToDo myToDo = new OverviewMyToDo();
        OverviewPeople people = new OverviewPeople();
        OverviewMeeting meeting = new OverviewMeeting();

        //Automatically loads saved data at the start of the program
        //PLEASE USE THE TEXT FILES THAT HAVE BEEN SENT WITH THE PROGRAM
        myToDo.LoadFromFile();
        people.LoadFromFile();
        meeting.LoadFromFile();

        int userInput = -1;

        while (userInput != 0)
        {
            mainMenu.DisplayMenu();
            userInput = mainMenu.GetUserSelection();
        
            if (userInput == 1)
            {
                //Create a New To Do Item
                myToDo.CreateNewItem();

                Console.WriteLine();
                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == 2)
            {
                //Display Open To Do Items
                myToDo.DisplayOpenItems("Jackson");
                
                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == 3)
            {
                //Create a New  Person
                people.CreateNewPerson();

                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }

            else if (userInput == 4)
            {
                //Create a New Item to Discuss with Someone
                people.CreateNewItem();

                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }

            else if (userInput == 5)
            {
                //Display Items to Discuss
                people.DisplayOpenItems();

                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == 6)
            {
                //Create a New Meeting
                meeting.CreateNewMeeting(people.GetCategories(), myToDo.GetCategories());

                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }

            else if (userInput == 7)
            {
                //Display Notes from a Meeting
                meeting.DisplayOpenItems();

                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == 8)
            {
                //Save Data to File
                myToDo.SaveToFile();
                people.SaveToFile();
                meeting.SaveToFile();
                
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("All data has been saved to a file.");
                Console.WriteLine();

                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == 9)
            {
                //Load Data from File
                myToDo.LoadFromFile();
                people.LoadFromFile();
                meeting.LoadFromFile();

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("All data has been loaded from the files.");
                Console.WriteLine();

                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }            
            else if (userInput == 0)
            {
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
                Console.Write("Press enter to return to the main menu.");
                Console.ReadLine();
            }
        }
    }
}