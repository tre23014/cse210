public class ExtremeHigh : BloodSugar
{
    private string _nextStepsEH;
    private string _insulinEH;
    private string _ketonesEH;
    private string _waterEH;

    public ExtremeHigh(string nextStepsEH, string insulinEH, string ketonesEH, string waterEH)
    {
        _nextStepsEH = nextStepsEH;
        _insulinEH = insulinEH;
        _ketonesEH = ketonesEH;
        _waterEH = waterEH;
    }

    public string GetNextStepsEH()
    {
        return _nextStepsEH;
    }

    public string GetInsulinEH()
    {
        return _insulinEH;
    }

    public string GetKetonesEH()
    {
        return _ketonesEH;
    }

    public string GetWaterEH()
    {
        return _waterEH;
    }

    public override void Base()
    {
        Console.WriteLine("You are Extremely High!");
    }
}