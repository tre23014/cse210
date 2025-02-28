
// ReflectionActivity inherits from Activity
using System.Data.SqlTypes;

public class ReflectionActivity : Activity
{
    private string _prompt;
    private string _question1;
    private string _question2;


    // Constructor for ReflectionActivity that passes values to the base Activity class
    public ReflectionActivity(string intro, string instructions, int chosenTime, string getReady, string exit, string prompt, string question1, string question2)
        : base(intro, instructions, chosenTime, getReady, exit)
    {
        _prompt = prompt;
        _question1 = question1;
        _question2 = question2;
    }

    public string GetPrompt()
    {
        return _prompt;
    }
    public string GetQuestion1()
    {
        return _question1;
    }
    public string GetQuestion2()
    {
        return _question2;
    }
}
