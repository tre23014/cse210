public class ExtremeLowBloodSugar : BloodSugar
{
    private string _food;
    private string _nextSteps;
    
    public ExtremeLowBloodSugar(string food, string nextSteps)
    {
        _food = food;
        _nextSteps = nextSteps;
    }

    public string GetFood()
    {
        return _food;
    }

    public string GetNextSteps()
    {
        return _nextSteps;
    }

    public override void Base()
    {
        Console.WriteLine("You are Extremely Low!");
    }

}

