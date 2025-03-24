public class Journal
{

    // this class manages entries like "add, display, save and load" journal entries

    private List<Entry> _entries = new List<Entry>(); // a list to store entry object
    private string _delimiter = "|";  // this is to delimit when saving and loading entries

    // add new entry
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // display entries in the journal
    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    // save entries into the journal to a file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry.Date}{_delimiter}{entry.Prompt}{_delimiter}{entry.Response}");
                }
            }
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    // load journal entries from a file using data delimiter
    public void LoadFromFile(string filename)
    {
        try
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(_delimiter);
                    if (parts.Length == 3)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        _entries.Add(new Entry(prompt, response, date));
                    }
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
        catch (Exception ex) // this ensure the user if there's an issue when loading the file
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
