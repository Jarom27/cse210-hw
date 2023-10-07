class PromptGenerator
{
    public List<string> _promptList = new List<string> { "What is the new thing?", "Other thing", "How is it going?", "What was your favorite part in the day?" };

    public string Generate()
    {
        return _promptList[new Random().Next(_promptList.Count - 1)];
    }
}