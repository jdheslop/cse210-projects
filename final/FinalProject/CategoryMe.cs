public class CategoryMe : Category
{
    //Attributes

    //Constructors
    public CategoryMe()
    {
        _categoryName = "Jackson";
    }

    public CategoryMe(string objectString)
    {
        _categoryName = objectString;
    }

    //Methods
    public override string CreateStringForFileSave()
    {
        return $"CategoryMe|{_categoryName}";
    }
    protected override void GatherCategoryData()
    {
        //NEED TO DO THIS
    }

    public override int DisplayItems(string status, bool completedStatus, int counter)
    {
        foreach (Item item in _items)
        {
            string toDoDateStatus = item.ToDoDateStatus();
            if (toDoDateStatus == status && item.GetIsComplete() == completedStatus)
            {
                Console.Write($"{counter}. ");    
                Console.WriteLine(item.GetItemDescription());
                counter += 1;
            }
        }
        return counter;
    }

    public override int ParseItems(string status, bool completedStatus, int position, int completedItem)
    {
        foreach (Item item in _items)
        {
            string toDoDateStatus = item.ToDoDateStatus();
            if (toDoDateStatus == status && item.GetIsComplete() == completedStatus)
            {
                if (completedItem == position)
                {
                    item.SetIsComplete(true);
                    position += 1;
                }
                else
                {
                    position += 1;
                }
            }
        }
        return position;        
    }

}