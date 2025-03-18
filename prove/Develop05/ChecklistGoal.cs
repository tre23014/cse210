public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public void RecordProgress()
    {
        _timesCompleted++;
        if (_timesCompleted == _targetCount) // Only add bonus when fully completed
        {
            Console.WriteLine($"Congratulations! You've completed {GetName()} and earned a bonus of {_bonus} points!");
        }
    }


    public override bool isComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public int GetTargetCount()
    {
        return _targetCount;
    }
}
