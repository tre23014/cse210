public class Low : BloodSugar
{
    private string _nextStepsL;
    private string _foodL;

    public Low(string bloodIntro, string nextStepsL, string foodL) : base(bloodIntro)
    {
        _nextStepsL = nextStepsL;
        _foodL = foodL;
    }

    public string GetNextStepsL()
    {
        return _nextStepsL;
    }

    public string GetFoodL()
    {
        return _foodL;
    }
}