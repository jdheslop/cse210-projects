public class CategoryMeeting : Category
{
    //Attributes

    //Constructors
    public CategoryMeeting()
    {
        GatherCategoryData();
    }

    public CategoryMeeting(string objectString)
    {
        _categoryName = objectString;
        //NEED TO DO 
    }

    //Methods
    public override string CreateStringForFileSave()
    {
        //NEED TO DO 
        return $"";
    }
    protected override void GatherCategoryData()
    {
        //NEED TO DO 
    }

    public override int DisplayItems(string status, bool completedStatus, int counter)
    {
        //NEED TO DO 
        return 1;
    }



}