public class OverviewMyToDo : Overview
{
    //Attributes

    //Constructors
    public OverviewMyToDo()
    {
        CategoryMe jackson = new CategoryMe();
        _categories.Add(jackson);
        _fileNameCategories = "FileMeCategories.txt";
        _fileNameItems = "FileMeItems.txt";
    }

    //Methods

    public void CreateNewItem()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Create a New To Do Item");
        Console.WriteLine();

        Console.WriteLine("What is the item description: ");
        Console.Write("> ");
        string itemDescription = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("What is the due date (YYYY-MM-DD)? Press enter if there is no due date. ");
        Console.Write("> ");
        string dateEntry = Console.ReadLine();

        if (dateEntry == "")
        {
            ItemNoDate newItem = new ItemNoDate(itemDescription);
            AddItemToCategoryItemList(newItem, "Jackson");
        }
        else{
            ItemDueDate newItem = new ItemDueDate(dateEntry, itemDescription);
            AddItemToCategoryItemList(newItem, "Jackson");
        }
    }

    public void DisplayOpenItems(string categoryName)
    {
        foreach (CategoryMe cat in _categories)
        {
            if (cat.GetCategoryName() == categoryName)
            {
                Console.Clear();
                Console.WriteLine("Open To Do Items");
                Console.WriteLine();

                int counter = 1;

                Console.WriteLine("Here are the Open Items that are due Today:");
                counter = cat.DisplayItems("today", false, counter);
                Console.WriteLine();
                        
                Console.WriteLine("Here are the Open Items that are Overdue:");
                counter = cat.DisplayItems("overdue", false, counter);
                Console.WriteLine();
                
                Console.WriteLine("Here are the Open Items without a Due Date:");
                counter = cat.DisplayItems("noDate", false, counter);
                Console.WriteLine();

                Console.WriteLine("Here are the Open Items due in the Future:");
                counter = cat.DisplayItems("future", false, counter);
                Console.WriteLine();

                Console.WriteLine("Enter 0 to quit.");
                Console.WriteLine();

                Console.Write("Which item has been completed: ");
                int completedItem = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //This finds the item which was selected and changes _isComplete to "true"
                cat.ChangeSelectedItem(completedItem);
                ClearDisplayPosition();           
            }
        }
    }
}