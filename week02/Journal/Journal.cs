public class Journal
{
    private static readonly string fileName = Path.Combine(AppContext.BaseDirectory, "journal.txt");
    public List<Entry> _entries;

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        SaveToFile();
    }

    public Journal()
    {
        _entries = LoadFromFile();

    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        try
        {
            using (StreamWriter writer = new (fileName))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error saving journal to file '{fileName}': {ex.Message}");
        }


    }

    public List<Entry> LoadFromFile()
    {
        if (File.Exists(fileName))
        {
            _entries = new List<Entry>();
            // _entries.Clear();

            using (StreamReader reader = new(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new()
                        {
                            _date = parts[0],
                            _promptText = parts[1],
                            _entryText = parts[2]
                        };
                        _entries.Add(entry);
                    }
                }
            }

        }
        else
        {
            _entries = new List<Entry>();
            Console.WriteLine($"File {fileName} does not exist.");
        }
        return _entries;
    }

}