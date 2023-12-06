public class ItemNoDate : Item
{
    //Attributes

    //Constructors
    public ItemNoDate(string description)
    {
        _withDueDate = false;
        _isComplete = false;
        _itemDescription = description;
    }

    public ItemNoDate(string itemDescription, string withDueDate, string isComplete)
    {
        _itemDescription = itemDescription;
        _withDueDate = Convert.ToBoolean(withDueDate);
        _isComplete = Convert.ToBoolean(isComplete);
    }

    //Methods
}