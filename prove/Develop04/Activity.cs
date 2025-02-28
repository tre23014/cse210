public class Activity
{

    private string _intro;
    private string _instructions;
    protected int _chosenTime;
    private string _getReady;
    private string _exit;

    public Activity(string intro, string instructions, int chosenTime, string getReady, string exit)
    {
        _intro = intro;
        _instructions = instructions;
        _chosenTime = chosenTime;
        _getReady = getReady;
        _exit = exit;
    }

    public string GetIntro()
    {
        return _intro;  // Simply returning the stored intro
    }

    public string GetInstructions()
    {
        return _instructions;
    }

    public int GetTime()
    {
        return _chosenTime;  // Simply returning the stored intro
    }
    public string GetReady()
    {
        return _getReady;
    }
    public string GetExit()
    {
        return _exit;
    }

    // public string GetActivityIntro()
    // {
    //     return $"{_intro}";
    // }
    // public string GetActivityInstructions()
    // {
    //     return $"{_instructions}";
    // }
    // public string GetOut()
    // {
    //     return $"{_exit}";
    // }

}