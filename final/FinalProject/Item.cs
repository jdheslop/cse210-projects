public abstract class Item
{
    // Attributes
    protected string _itemDescription;
    protected bool _withDueDate;
    protected bool _isComplete;
    protected DateTime _dueDate;
 
    //Methods  
    public bool GetWithDueDate()
    {
        return _withDueDate;
    }
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

    public abstract string CreateStringForFileSave();

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
}