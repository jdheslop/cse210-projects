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
            cat.ClearDisplayPosition();
        }
    }

    public void ChangeSelectedCategory(int selectedCategory)
    {
        foreach (Category cat in _categories)
        {
            if (selectedCategory == cat.GetDisplayPosition())
            {
                
            }
        }
    }

    protected void DisplayCategories()
    {
        //NEED TO DO
    }




    protected void AddItemToCategoryList()
    {
        //NEED TO DO
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

    public abstract void CreateNewItem();

    public void SaveToFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileNameCategories))
        {
            foreach (Category category in _categories)
            {
                outputFile.WriteLine(category.CreateStringForFileSave());

                category.SaveItemsToFile(_fileNameItems, category.GetCategoryName());
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

    private void CreateCategoryFromString(string line)
    {
        string[] splitList = line.Split("|");
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
    }


}