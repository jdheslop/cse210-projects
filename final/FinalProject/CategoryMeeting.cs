public class CategoryMeeting : Category
{
    //Attributes
    DateTime _meetingDate;
    string _meetingParticipants;

    //Constructors
    public CategoryMeeting()
    {
        GatherCategoryData();
    }

    public CategoryMeeting(string objectString)
    {
        string[] splitList = objectString.Split("|");
        _categoryName = splitList[0];
        _meetingDate = DateTime.ParseExact(splitList[1], "dd.MM.yyyy HH:mm:ss", null);
        _meetingParticipants = splitList[2];
    }

    //Methods
    public override string CreateStringForFileSave()
    {
        return $"CategoryMeeting§{_categoryName}|{_meetingDate}|{_meetingParticipants}";
    }

    protected override void GatherCategoryData()
    {
        Console.WriteLine("What is the name of the meeting: ");
        Console.Write("> ");
        string meetingName = Console.ReadLine();
        
        Console.WriteLine("What is the meeting date (YYYY-MM-DD)?");
        Console.Write("> ");
        string dateEntry = Console.ReadLine();
        _meetingDate = DateTime.ParseExact(dateEntry, "yyyy-MM-dd", null);

        _categoryName = $"{meetingName} - {dateEntry}";

        Console.WriteLine("Who participated in the meeting: ");
        Console.Write("> ");
        _meetingParticipants = Console.ReadLine();
        Console.WriteLine();
    }

    public override int DisplayItems(string status, bool completedStatus, int counter)
    {
        Console.WriteLine($"{_categoryName}");
        Console.WriteLine($"Participants: {_meetingParticipants}");
        foreach (Item item in _items)
        {
            Console.WriteLine($"> {item.GetItemDescription()}");
        }
        return 0;
    }
}