class Entry
{
    public int _id;
    public string _title;
    public string _description;
    public string _date;
    public void Display()
    {
        Console.WriteLine($"{_title} ");
    }
}