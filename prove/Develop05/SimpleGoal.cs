public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(int score, string title, string description, bool isComplete) : base(score, title, description)
    {
        _isComplete = isComplete;
        _currentlyScore = 0;
    }
    public SimpleGoal(int score, int currently, string title, string description) : base(score, currently, title, description)
    {
        _isComplete = false;
    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    public void Complete()
    {
        _isComplete = true;
    }
    public override void CalculatePoints()
    {
        if (IsComplete())
        {
            _currentlyScore = _score;
        }

    }
    public override void GetGoalInfo()
    {
        if (IsComplete())
        {
            Console.WriteLine($"[X] {_title} ({_description})");
            return;
        }
        Console.WriteLine($"[ ] {_title} ({_description})");

    }
    public override string SaveGoalInfo()
    {
        return $"SimpleGoal:{_title},{_description},{_score},{_isComplete}";
    }
}