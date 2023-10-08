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
        Console.WriteLine();
    }
    public void InsertEntry()
    {
        string promt = _promptGenerator.Generate();
        Entry newEntry = new Entry();
        newEntry._title = promt;
        Console.WriteLine(promt);
        newEntry._description = Console.ReadLine();
        Console.Write("Write a PD or only type an enter to continue: ");
        newEntry._postData = Console.ReadLine();
        newEntry._date = DateTime.Now.ToShortDateString();

        _entries.Add(newEntry);
    }
    public void Save(string filename)
    {
        using (StreamWriter stream = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                stream.WriteLine($"{entry._title},{entry._description},{entry._date},{entry._postData}");
            }

        }
    }
    public void Load(string filename)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] columns = line.Split(",");
                Entry newEntry = new Entry();
                newEntry._title = columns[0];
                newEntry._description = columns[1];
                newEntry._date = columns[2];
                newEntry._postData = columns[3];
                _entries.Add(newEntry);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

    }
}