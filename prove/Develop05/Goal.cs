public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription() // Fixed method name
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract bool isComplete(); // Abstract method for completion check

    // Virtual method for recording progress (to be overridden in subclasses)
    public virtual void RecordProgress()
    {
        Console.WriteLine("This goal does not support progress tracking.");
    }
}
