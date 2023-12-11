public class EternalDemo
{
    private List<Goal> _listGoals;
    private int _totalPoints;
    public EternalDemo()
    {
        _listGoals = new List<Goal>();
        _totalPoints = 0;
    }
    public void DisplayGoals()
    {
        Console.WriteLine("The goals are: ");
        int counter = 1;
        int score = 0;
        foreach (Goal goal in _listGoals)
        {
            Console.Write($"{counter}. ");
            goal.GetGoalInfo();
            score = score + goal.GetCurrentlyScore();
            counter++;
        }
        Console.WriteLine();
        Console.WriteLine($"You have {score} points");

    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n 1.Simple Goal\n 2.Eternal Goal\n 3.Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int option = int.Parse(Console.ReadLine());
        Goal newGoal = null;
        switch (option)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                string title = Console.ReadLine();
                Console.Write("What is a short description? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int score = int.Parse(Console.ReadLine());
                newGoal = new SimpleGoal(score, title, description);
                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                title = Console.ReadLine();
                Console.Write("What is a short description? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                score = int.Parse(Console.ReadLine());
                newGoal = new EternalGoal(score, title, description);
                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                title = Console.ReadLine();
                Console.Write("What is a short description? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                score = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int timesToComplete = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplish it many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new CheckListGoal(score, title, description, timesToComplete, bonus);
                break;
        }
        _listGoals.Add(newGoal);
        newGoal.CalculatePoints();
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        Goal goal = null;
        bool firstLine = true;
        foreach (string line in lines)
        {
            if (firstLine)
            {
                _totalPoints = int.Parse(line);
                continue;
            }
            string[] firstDivision = line.Split(":");
            string[] infoLine = firstDivision[1].Split(",");
            switch (firstDivision[0])
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(score: int.Parse(infoLine[2]), title: infoLine[0], description: infoLine[1], isComplete: bool.Parse(infoLine[3]));
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(score: int.Parse(infoLine[2]), title: infoLine[0], description: infoLine[1]);
                    break;
                case "CheckListGoal":
                    break;
            }
            _listGoals.Add(goal);
        }

    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            SumAllPoints();
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in _listGoals)
            {

                outputFile.WriteLine($"{goal.SaveGoalInfo()}");
            }


        }
    }
    private void SumAllPoints()
    {
        foreach (Goal goal in _listGoals)
        {
            _totalPoints = goal.GetCurrentlyScore();
        }
    }
    public void RecordEvent()
    {

    }
}