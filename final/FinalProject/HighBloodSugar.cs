public class High : BloodSugar
{
    private string _nextStepsH;
    private string _insulin;
    private string _water;

    public High(string bloodIntro, string nextStepsH, string insulin, string water) : base(bloodIntro)
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
}