class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}\n\n{_description}");
    }
    public void DisplayEndingMessage()
    {

    }
    public void PauseSpinner()
    {

    }
    public void PauseCountDown()
    {

    }
    public virtual void Run()
    {

    }
}