public class WritingAssignment: Assignment
{
    private string _title = "";
    public WritingAssignment(string studentName, string topic, string title): base(studentName, topic)
    {
        _title = title;
    }
    public string getTitle()
    {
        return _title;
    }
    public void setTitle(string title)
    {
        _title = title;
    }
    public string GetWritingInfo()
    {
        return $"{_title} by {_studentName}";
    }
}