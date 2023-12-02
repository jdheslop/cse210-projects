public abstract class Category
{
    //Attributes
    protected List<Item> _items = new List<Item>();
    protected string _categoryName;
    int _displayPosition;

    //Methods

    public string GetCategoryName()
    {
        return _categoryName;
    }

    public void AddToItemList(Item item)
    {
        _items.Add(item);
    }
    public void SetDisplayPosition(int position)
    {
        _displayPosition = position;
    }
    public int GetDisplayPosition()
    {
        return _displayPosition;
    }

    public abstract string CreateStringForFileSave();

    public abstract int DisplayItems(string status, bool completedStatus, int counter);

    public void ChangeSelectedItem(int selectedItem)
    {
        foreach (Item item in _items)
        {
            if (selectedItem == item.GetDisplayPosition())
            {
                item.SetIsComplete(true);
            }
        }
    }

    public void ClearDisplayPosition()
    {
        foreach (Item item in _items)
        {
            item.SetDisplayPosition(0);
        }
    }

    protected abstract void GatherCategoryData();

    public void SaveItemsToFile(string fileName, string categoryName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Item item in _items)
            {
                outputFile.WriteLine($"{categoryName}§{item.CreateStringForFileSave()}");
            }
        }
    }

    public List<Item> LoadFromItemFile(string fileName,  string categoryName)
    {
        List<Item> tempItemList = new List<Item>();
        
        _items.Clear();
        string[] fileAsList = System.IO.File.ReadAllLines(fileName);

        foreach (string line in fileAsList)
        {
            string[] splitList = line.Split("§");
            string catName = splitList[0];

            if (catName == categoryName)
            {
                string itemStringFull = splitList[1];

                splitList = itemStringFull.Split("°");
                string itemType = splitList[0];
                string objectString = splitList[1];

                if (itemType == "ItemDueDate")
                {
                    ItemDueDate newItem = new ItemDueDate(objectString);
                    tempItemList.Add(newItem);
                }
                else if (itemType == "ItemNoDate")
                {
                    string[] parts = objectString.Split("|");
                    ItemNoDate newItem = new ItemNoDate(parts[0], parts[1], parts[2]);
                    tempItemList.Add(newItem);
                }
            }
        }
        return tempItemList;


    }

    

}