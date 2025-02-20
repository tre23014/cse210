public class writingAssingment : Assingment
{
    private string _title;

    public writingAssingment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }

    public string getWritingInfo()
    {
        string studentName = getStudentName();

        return $"{_title} by {studentName}";
    }
}