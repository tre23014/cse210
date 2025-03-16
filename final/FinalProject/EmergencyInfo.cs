public class EmergencyInfo
{
    private string _intro;
    private string _info;
    private string _exit;

    public EmergencyInfo(string intro, string info, string exit)
    {
        _intro = intro;
        _info = info;
        _exit = exit;
    }

    public string GetIntro()
    {
        return _intro;
    }
    public string GetInfo()
    {
        return _info;
    }
    public string GetExit()
    {
        return _exit;
    }
}