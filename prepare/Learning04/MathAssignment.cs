public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problem = "";
    public MathAssignment(string studentName, string topic, string textbookSection, string problem): base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }
    public string getTextbookSection()
    {
        return _textbookSection;
    }
    public void setTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }
    public string getProblem()
    {
        return _problem;
    }
    public void setProblem(string problem)
    {
        _problem = problem;
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problem}";
    }
}