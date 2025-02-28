public class BreathingActivity : Activity
{
    private string _bin;
    private string _bout;
    public BreathingActivity(string intro, string instructions, int chosenTime, string getReady, string exit, string bin, string bout)
        : base(intro, instructions, chosenTime, getReady, exit)
    {
        _bin = bin;
        _bout = bout;
    }

    public string GetBreathIn()
    {
        return _bin;
    }
    public string GetBreathOut()
    {
        return _bout;
    }

}