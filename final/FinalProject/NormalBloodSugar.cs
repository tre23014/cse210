public class Normal : BloodSugar
{
    private string _normal;

    public Normal(string bloodIntro, string normal) : base(bloodIntro)
    {
        _normal = normal;
    }

    public string GetNormal()
    {
        return _normal;
    }
}