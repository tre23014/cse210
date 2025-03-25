public class ExtremeLowBloodSugar : BloodSugar
{
    private string _food;
    private string _nextSteps;
    
    public ExtremeLowBloodSugar(string bloodIntro, string food, string nextSteps) : base(bloodIntro)
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

}

