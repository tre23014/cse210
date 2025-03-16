public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public void MarkComplete()
    {
        _isComplete = rue;
    }
}
