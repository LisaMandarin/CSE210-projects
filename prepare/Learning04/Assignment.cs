public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string getStudentName()
    {
        return _studentName;
    }
    public void setStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public string getTopic()
    {
        return _topic;
    }
    public void setTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary ()
    {
        return $"{_studentName} - {_topic}";
    }
}