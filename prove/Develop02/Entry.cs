class Entry
{
    public int _id;
    public string _title;
    public string _description;
    public string _date;

    public string _postData;
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_title}\n{_description}\nPD: {_postData}");
    }
}