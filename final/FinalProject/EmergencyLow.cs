

public class EmergencyLow : EmergencyInfo
{
    private string _lowFoodInfoIntro;
    private string _lowFoodInfoStep1;
    private string _lowFoodInfoStep2;
    private string _lowFoodInfoStep3;
    private string _lowFoodInfoStep4;
    private string _lowFoodInfoFinal;
    private string _hopsital;
    private string _glucagon;

    public EmergencyLow(string intro, string info, string exit, string lowFoodInfoIntro, string lowFoodInfoStep1, string lowFoodInfoStep2, string lowFoodInfoStep3, string lowFoodInfoStep4, string lowFoodInfoFinal, string hospital, string glucagon) : base (intro, info, exit)
    {
        _lowFoodInfoIntro = lowFoodInfoIntro;
        _lowFoodInfoStep1 = lowFoodInfoStep1;
        _lowFoodInfoStep2 = lowFoodInfoStep2;
        _lowFoodInfoStep3 = lowFoodInfoStep3;
        _lowFoodInfoStep4 = lowFoodInfoStep4;
        _lowFoodInfoFinal = lowFoodInfoFinal;
        _hopsital = hospital;
        _glucagon = glucagon;
    }

    public string GetLowFoodInfoIntro()
    {
        return _lowFoodInfoIntro;
    }
    public string GetLowFoodInfoStep1()
    {
        return _lowFoodInfoStep1;
    }
    public string GetLowFoodInfoStep2()
    {
        return _lowFoodInfoStep2;
    }
    public string GetLowFoodInfoStep3()
    {
        return _lowFoodInfoStep3;
    }
    public string GetLowFoodInfoStep4()
    {
        return _lowFoodInfoStep4;
    }
    public string GetLowFoodInfoFinal()
    {
        return _lowFoodInfoFinal;
    }
    public string GetLowFoodInfoStep()
    {
        return _lowFoodInfoStep1;
    }
    public string GetHospital()
    {
        return _hopsital;
    }

    public string GetGlucagon()
    {
        return _glucagon;
    }
}