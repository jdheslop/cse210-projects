public class OverviewMeeting : Overview
{
    //Attributes
    List<Category> _listOfPeople = new List<Category>();
    List<Category> _myToDoList = new List<Category>();

    //Constructors
    public OverviewMeeting()
    {
        _fileNameCategories = "FileMeetingCategories.txt";
        _fileNameItems = "FileMeetingItems.txt";
    }

    //Methods
    public void CreateNewMeeting(List<Category> listOfPeople, List<Category> myToDoList)
    {
        _listOfPeople = listOfPeople;
        _myToDoList = myToDoList;

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Create a New Meeting");
        Console.WriteLine();

        CategoryMeeting newMeeting = new CategoryMeeting();

        TextToAddItemsToMeeting();
        
        string userEntry = "-1";
        string previousText = "";
        while (userEntry != "0")
        {
            Console.Write("> ");
            userEntry = Console.ReadLine();
            ItemInfo newInfoItem = new ItemInfo(userEntry);

            if (userEntry == "1")
            {
                CreateToDoItem(previousText);
            }
            else if (userEntry == "2")
            {
                CreateDiscussionItem(previousText);
            }
            else if (userEntry == "0")
            {
            }
            else
            {
                newMeeting.AddToItemList(newInfoItem);
            }

            previousText = userEntry;
        }
        _categories.Add(newMeeting);
    }

    private void TextToAddItemsToMeeting()
    {
        Console.WriteLine("Add notes to the meeting.");
        Console.WriteLine("Enter 1 to convert the previous note to a To Do Item.");
        Console.WriteLine("Enter 2 to convert the previous note to an Item to Discuss with someone.");
        Console.WriteLine("Enter 0 to quit");
        Console.WriteLine();

        Console.WriteLine("Add notes:");
    }

    private void CreateToDoItem(string previousText)
    {
        //Gather the needed information to To Do Item and add it to a list which is later used to add these Items to My To Do List.
        Console.WriteLine("What is the due date (YYYY-MM-DD)? Press enter if there is no due date. ");
        Console.Write("> ");
        string dateEntry = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Continue adding meeting notes:");

        if (dateEntry == "")
        {
            ItemNoDate newItem = new ItemNoDate(previousText);
            foreach (Category cat in _myToDoList)
            {
                cat.AddToItemList(newItem);
            }
        }
        else{
            ItemDueDate newItem = new ItemDueDate(dateEntry, previousText);
            foreach (Category cat in _myToDoList)
            {
                cat.AddToItemList(newItem);
            }
        }
    }

    private void CreateDiscussionItem(string previousText)
    {
        //Gather the needed information to create a Discussion Item and add it to a list which is later used to add these Items to the Person item list.

        //Select the Person the Discussion Item is attributed to.
        Console.WriteLine("Here are the available people:");
        int counter = 1;
        foreach (Category cat in _listOfPeople)
        {
            Console.WriteLine($"{counter}. {cat.GetCategoryName()}");
            cat.SetDisplayPosition(counter);
            counter += 1;
        }

        Console.WriteLine("Enter 0 to quit.");
        Console.WriteLine();

        Console.Write("Enter the number of the person you would like to discuss something with: ");
        int selectedNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Continue adding meeting notes:");

        foreach (Category cat in _listOfPeople)
        {
            if (selectedNumber == cat.GetDisplayPosition())
            {
                ItemNoDate newItem = new ItemNoDate(previousText);
                cat.AddToItemList(newItem);
                cat.SetDisplayPosition(0);
            }
        }
    }

    public void DisplayOpenItems()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Display Meeting Notes");
        Console.WriteLine();

        Console.WriteLine("Here are the available meetings:");

        int counter = 1;
        foreach (Category cat in _categories)
        {
            Console.WriteLine($"{counter}. {cat.GetCategoryName()}");
            cat.SetDisplayPosition(counter);
            counter += 1;
        }

        Console.WriteLine("Enter 0 to quit.");
        Console.WriteLine();

        Console.Write("Enter the number of the meeting to see the notes: ");
        int selectedMeeting = int.Parse(Console.ReadLine());
        Console.WriteLine();

        foreach (Category cat in _categories)
        {
            if (selectedMeeting == cat.GetDisplayPosition())
            {
                cat.DisplayItems("na", true, 0);
            }
        }

        Console.WriteLine();
        ClearDisplayPosition();
    }
}
