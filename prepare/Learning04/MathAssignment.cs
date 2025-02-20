public class mathAssingment : Assingment
{
    private string _textbookSection;
    private string _problems;

    public mathAssingment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string getTextBookSection()
    {
        return _textbookSection;
    }

    public string getProblems()
    {
        return _problems;
    }

    public string getHomework()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}