public class Normal : BloodSugar
{
    private string _normal;

    public Normal(string normal)
    {
        _normal = normal;
    }

    public string GetNormal()
    {
        return _normal;
    }
    
    public override void Base()
    {
        Console.WriteLine("Your blood sugar is Perfect!");
    }
}