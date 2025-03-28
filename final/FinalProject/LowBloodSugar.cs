public class Low : BloodSugar
{
    private string _nextStepsL;
    private string _foodL;

    public Low(string nextStepsL, string foodL) 
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
    
    public override void Base()
    {
        Console.WriteLine("You are a little low.");
    }
}