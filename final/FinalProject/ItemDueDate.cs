public class ItemDueDate : Item
{
    //Attributes

    //Constructors
    public ItemDueDate(string dueDate, string description)
    {
        _withDueDate = true;
        _isComplete = false;
        _dueDate = DateTime.ParseExact(dueDate, "yyyy-MM-dd", null);
        _itemDescription = description;
    }

    public ItemDueDate(string objectString)
    {
        string[] parts = objectString.Split("|");
        _itemDescription = parts[0];
        _withDueDate = Convert.ToBoolean(parts[1]);
        _isComplete = Convert.ToBoolean(parts[2]);
        _dueDate = DateTime.ParseExact(parts[3], "dd.MM.yyyy HH:mm:ss", null);
    }

    //Methods
    public override string CreateStringForFileSave()
    {
        return $"ItemDueDate°{_itemDescription}|{_withDueDate}|{_isComplete}|{_dueDate}";
    }  

}