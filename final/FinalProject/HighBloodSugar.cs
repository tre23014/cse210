public class High : BloodSugar
{
    private string _nextStepsH;
    private string _insulin;
    private string _water;

    public High(string nextStepsH, string insulin, string water)
    {
        _nextStepsH = nextStepsH;
        _insulin = insulin;
        _water = water;
    }

    public string GetNextStepsH()
    {
        return _nextStepsH;
    }

    public string GetInsulin()
    {
        return _insulin;
    }

    public string GetWater()
    {
        return _water;
    }
    
    public override void Base()
    {
        Console.WriteLine("You are a little High.");
    }
}