using System.Diagnostics.CodeAnalysis;

public class Assingment
{
    private string _studentName;
    private string _topic;

    public Assingment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string getStudentName()
    {
        return _studentName;
    }

    public string getTopic()
    {
        return _topic;
    }

    public string getSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}