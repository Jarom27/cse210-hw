public class Goal
{
    protected int _score;
    protected int _currentlyScore;
    protected string _title;
    protected string _description;
    public Goal(int score, string title, string description)
    {
        _score = score;
        _title = title;
        _description = description;
    }
    public int GetCurrentlyScore()
    {
        return _currentlyScore;
    }
    public void DisplayScore()
    {
        Console.WriteLine($"You have ${_currentlyScore}");
    }
    public Goal(int score, int currently, string title, string description)
    {
        _score = score;
        _currentlyScore = currently;
        _title = title;
        _description = description;
    }
    public virtual void CalculatePoints()
    {

    }
    public virtual void GetGoalInfo()
    {

    }
    public virtual string SaveGoalInfo()
    {
        return "";
    }
}