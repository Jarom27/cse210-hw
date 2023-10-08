class PromptGenerator
{
    public List<string> _promptList = new List<string> {
        "What was the new thing you happened today?",
        "How is it going?",
        "What was your favorite part in the day?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What miracle could you see today?",
        "How do you feel today?",
        "What was your favorite activity today?"
    };

    public string Generate()
    {
        return _promptList[new Random().Next(_promptList.Count - 1)];
    }
}