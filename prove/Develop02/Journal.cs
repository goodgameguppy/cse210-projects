using System;

public class Journal
{
    // attributes
    public List<Entry> _entries = [];

    // behaviors
    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are currently no journal entries.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void DeleteEntries()
    {
        int i = 0;
        foreach (Entry entry in _entries)
        {
            i++;
            Console.WriteLine($"Entry number: {i}");
            entry.DisplayEntry();
            Console.WriteLine();
        }
        Console.WriteLine("Which entry would you like to delete? Press 0 for none.");
        string strdelete = Console.ReadLine();
        int intdelete = int.Parse(strdelete);
        if (intdelete == 0)
        {
            return;
        }
        else
        {
            _entries.RemoveAt(intdelete-1);
        }
    }

    public void SaveJournal()
    {
        
    }

    public void LoadJournal()
    {
        
    }
}