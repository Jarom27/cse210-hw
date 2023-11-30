public class EternalGoal : Goal
{
    public EternalGoal(int score, string title, string description) : base(score, title, description)
    {
        _currentlyScore = 0;
    }
    public EternalGoal(int score, int currently, string title, string description) : base(score, currently, title, description)
    {

    }
    public override void CalculatePoints()
    {
        _currentlyScore = _currentlyScore + _score;
    }
    public override string SaveGoalInfo()
    {
        return $"EternalGoal:{_title},{_description},{_score}";
    }
}