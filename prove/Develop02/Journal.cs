class Journal
{
    public List<Entry> _entries;
    public PromptGenerator _promptGenerator;

    public Journal()
    {
        _promptGenerator = new PromptGenerator();
        _entries = new List<Entry>();
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void InsertEntry()
    {
        string promt = _promptGenerator.Generate();
        Entry newEntry = new Entry();
        newEntry._title = promt;
        Console.WriteLine(promt);
        newEntry._description = Console.ReadLine();
        newEntry._date = DateTime.Now.ToShortDateString();

        _entries.Add(newEntry);
    }
    public void Save(string filename)
    {

    }
    public void Load(string filename)
    {

    }
}