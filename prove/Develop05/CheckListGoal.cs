public class CheckListGoal : Goal
{
    private int _currentlyTimes;
    private int _timesToComplete;
    private int _bonus;
    private bool _isComplete;
    public CheckListGoal(int score, string title, string description, int timesToComplete, int bonus) : base(score, title, description)
    {
        _timesToComplete = timesToComplete;
        _currentlyScore = 0;
        _currentlyTimes = 0;
        _bonus = bonus;
        _isComplete = false;
    }
    public CheckListGoal(int score, int currently, string title, string description, int currentlyTimes, int timesToComplete, int bonus) : base(score, currently, title, description)
    {
        _currentlyTimes = currentlyTimes;
        _timesToComplete = timesToComplete;
        _bonus = bonus;

    }
    public override void CalculatePoints()
    {
        if (_currentlyTimes >= _timesToComplete && !_isComplete)
        {
            _currentlyScore = _currentlyScore + _bonus;
            _isComplete = true;
        }
        _currentlyScore = _currentlyScore + _score;
    }
    public override void GetGoalInfo()
    {
        if (_isComplete)
        {
            Console.WriteLine($"[X] {_title} ({_description}) --- Currently completed: {_currentlyTimes}/{_timesToComplete}");
        }
        else
        {
            Console.WriteLine($"[ ] {_title} ({_description}) --- Currently completed: {_currentlyTimes}/{_timesToComplete}");
        }
    }
    public override string SaveGoalInfo()
    {
        return $"CheckListGoal:{_title},{_description},{_score},{_bonus},{_timesToComplete},{_currentlyTimes}";
    }
}