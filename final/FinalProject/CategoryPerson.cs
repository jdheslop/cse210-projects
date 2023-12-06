public class CategoryPerson : Category
{
    //Attributes

    //Constructors
    public CategoryPerson()
    {
        GatherCategoryData();
    }

    public CategoryPerson(string objectString)
    {
        _categoryName = objectString;
    }

    //Methods
    public override string CreateStringForFileSave()
    {
        return $"CategoryPerson§{_categoryName}";
    }

    protected override void GatherCategoryData()
    {
        Console.WriteLine("What is the name of the person: ");
        Console.Write("> ");
        _categoryName = Console.ReadLine();
        Console.WriteLine();
    }

    public override int DisplayItems(string status, bool completedStatus, int counter)
    {
        if (_items.Count() > 0)
        {
            Console.WriteLine(_categoryName);

            foreach (Item item in _items)
            {
                if (item.GetIsComplete() == completedStatus)
                {
                    Console.WriteLine($"{counter}. {item.GetItemDescription()}");
                    item.SetDisplayPosition(counter);
                    counter += 1;
                }
            }
        }
        return counter;
    }
}