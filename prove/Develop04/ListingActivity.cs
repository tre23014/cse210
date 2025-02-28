public class ListingActivity : Activity
{
    private string _prompt;
    private string _list;
    public ListingActivity(string intro, string instructions, int chosenTime, string getReady, string exit, string prompt, string list)
        : base(intro, instructions, chosenTime, getReady, exit)
    {
        _prompt = prompt;
        _list = list;
    }

    public string GetPrompt()
    {
        return _prompt;
    }
    public string GetList()
    {
        return _list;
    }

    public void GetUserReponses(int duration)
    {

    }

}