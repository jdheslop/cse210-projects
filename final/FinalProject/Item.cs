public abstract class Item
{
    // Attributes
    protected string _itemDescription;
    protected bool _withDueDate;
    protected bool _isComplete;
    protected DateTime _dueDate;
    int _displayPosition;
 
    //Methods  
    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool status)
    {
        _isComplete = status;
    }

    public string GetItemDescription()
    {
        return _itemDescription;
    }

    public void SetDisplayPosition(int position)
    {
        _displayPosition = position;
    }

    public int GetDisplayPosition()
    {
        return _displayPosition;
    }

    public string ToDoDateStatus()
    {
        if (_withDueDate == false)
        {
            return "noDate";
        }
        else
        {
            if (_dueDate == DateTime.Now.Date)
            {
                return "today";
            }
            else if (_dueDate < DateTime.Now.Date)
            {
                return "overdue";
            }
            else if (_dueDate > DateTime.Now.Date)
            {
                return "future";
            }
            else
            {
                return "error";
            }
        }
    }

    public virtual string CreateStringForFileSave()
    {
        return $"ItemNoDate°{_itemDescription}|{_withDueDate}|{_isComplete}";
    }
}