public abstract class Overview
{
    //Attributes
    protected List<Category> _categories = new List<Category>();
    protected string _fileNameCategories;
    protected string _fileNameItems;

    //Methods
    public void ClearDisplayPosition()
    {
        foreach (Category cat in _categories)
        {
            cat.SetDisplayPosition(0);
            cat.ClearDisplayPositionInItems();
        }
    }

    public List<Category> GetCategories()
    {
        return _categories;
    }

    protected void AddItemToCategoryItemList(Item item, string categoryName)
    {
        foreach (Category cat in _categories)
        {
            if (cat.GetCategoryName() == categoryName)
            {
                cat.AddToItemList(item);
            }
        }
    }

    public void SaveToFile()
    {
        using (StreamWriter categoryOutputFile = new StreamWriter(_fileNameCategories))
        {   using (StreamWriter itemOutputFile = new StreamWriter(_fileNameItems))
            {
                foreach (Category category in _categories)
                {
                    categoryOutputFile.WriteLine(category.CreateStringForFileSave());

                    category.SaveItemsToFile(itemOutputFile, category.GetCategoryName());
                }
            }
        }
    }

    public void LoadFromFile()
    {
        _categories.Clear();
        string[] fileAsList = System.IO.File.ReadAllLines(_fileNameCategories);

        foreach (string line in fileAsList)
        {
            CreateCategoryFromString(line);
        }
        
        foreach (Category cat in _categories)
        {
            List<Item> tempItemList = new List<Item>();
            tempItemList = cat.LoadFromItemFile(_fileNameItems, cat.GetCategoryName());

            foreach (Item item in tempItemList)
            {
                cat.AddToItemList(item);
            }
        }
    }

    protected void CreateCategoryFromString(string line)
    {
        string[] splitList = line.Split("§");
        string type = splitList[0];
        string objectString = splitList[1];

        if (type == "CategoryMe")
        {
            CategoryMe newCategory = new CategoryMe(objectString);
            _categories.Add(newCategory);
        }
        else if (type == "CategoryPerson")
        {
            CategoryPerson newCategory = new CategoryPerson(objectString);
            _categories.Add(newCategory);
        }
        else if (type == "CategoryMeeting")
        {
            CategoryMeeting newCategory = new CategoryMeeting(objectString);
            _categories.Add(newCategory);
        }
    }
}