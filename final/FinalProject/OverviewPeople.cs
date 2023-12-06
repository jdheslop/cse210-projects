public class OverviewPeople : Overview
{
    //Attributes

    //Constructors
    public OverviewPeople()
    {
        _fileNameCategories = "FilePeopleCategories.txt";
        _fileNameItems = "FilePeopleItems.txt";
    }

    //Methods
    public void CreateNewPerson()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Create a New Person");
        Console.WriteLine();

        CategoryPerson newPerson = new CategoryPerson();
        _categories.Add(newPerson);
    }

    public void CreateNewItem()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Create a New Item to Discuss with Someone");
        Console.WriteLine();

        Console.WriteLine("Here are the available people:");
        int counter = 1;
        foreach (Category cat in _categories)
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

        if (selectedNumber > 0  && selectedNumber <= _categories.Count())
        {
            Console.WriteLine("What is the item to discuss: ");
            Console.Write("> ");
            string itemDescription = Console.ReadLine();
            Console.WriteLine();

            string selectedPerson = "No One";
            foreach (Category cat in _categories)
            {
                if (selectedNumber == cat.GetDisplayPosition())
                {
                    selectedPerson = cat.GetCategoryName();
                }
            }

            ItemNoDate newItem = new ItemNoDate(itemDescription);
            AddItemToCategoryItemList(newItem, selectedPerson);
            ClearDisplayPosition();
        }
        else if (selectedNumber == 0)
        {}
        else{
            Console.WriteLine("Invalid entry.");
        }
    }

    public void DisplayOpenItems()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Display Items to Discuss");
        Console.WriteLine();

        int counter = 1;
        foreach (Category cat in _categories)
        {
            List<Item> tempItemsList = cat.GetItems();
            bool allCompleted = true;

            foreach (Item item in tempItemsList)
            {
                if (item.GetIsComplete() == false)
                {
                    allCompleted = false;                    
                }
            }

            if (allCompleted == false)
            { 
                counter = cat.DisplayItems("na", false, counter);
                Console.WriteLine();
            }
        }

        Console.WriteLine("Enter 0 to quit.");
        Console.WriteLine();

        Console.Write("Which item has been completed: ");
        int completedItem = int.Parse(Console.ReadLine());
        Console.WriteLine();

        foreach (Category cat in _categories)
        {
            cat.ChangeSelectedItem(completedItem);
        }
        
        ClearDisplayPosition();
    }

}