public class ItemInfo : Item
{
    //Attributes


    //Constructors
    public ItemInfo(string description)
    {
        _withDueDate = false;
        _isComplete = true;
        _itemDescription = description;
    }

    public ItemInfo(string itemDescription, string withDueDate, string isComplete)
    {
        
        _itemDescription = itemDescription;
        _withDueDate = Convert.ToBoolean(withDueDate);
        _isComplete = Convert.ToBoolean(isComplete);
    }

    //Methods
    public override string CreateStringForFileSave()
    {
        return $"ItemInfo°{_itemDescription}|{_withDueDate}|{_isComplete}";
    }  




}