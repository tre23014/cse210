public class EmergencyHigh : EmergencyInfo
{
    private string _basicHigh;
    private string _ketones;
    private string _ketoacidosis;
    private string _ketoacidosisHome;
    private string _hospitalHigh;

    public EmergencyHigh(string intro, string info, string exit, string basicHigh, string ketones, string ketoacidosis, string ketoacidosisHome, string hospitalHigh) : base (intro, info, exit)
    {
        _basicHigh = basicHigh;
        _ketones = ketones;
        _ketoacidosis = ketoacidosis;
        _ketoacidosisHome = ketoacidosisHome;
        _hospitalHigh = hospitalHigh;
    }

    public string GetBasicHigh()
    {
        return _basicHigh;
    }

    public string GetKetones()
    {
        return _ketones;
    }

    public string GetKetoacidosis()
    {
        return _ketoacidosis;
    }

    public string GetKetoacidosisHome()
    {
        return _ketoacidosisHome;
    }

    public string GetHospitalHigh()
    {
        return _hospitalHigh;
    }
}