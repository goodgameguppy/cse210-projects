using System;
using System.Collections.Generic;
using System.IO;

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

    public void SaveJournal(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);

        writer.WriteLine("Date^Prompt^Response^LastEdit");

        foreach (Entry entry in _entries)
        {
            string lastEdit = "";

            if (entry._lastEdit.HasValue)
            {
                lastEdit = entry._lastEdit.Value.ToString();
            }

            writer.WriteLine(
                $"{entry._date}^{entry._prompt}^{entry._response}^{lastEdit}");
        }

        Console.WriteLine("Journal saved.");
    }
    public void LoadJournal(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('^');

            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(prompt, response);

            entry._date = DateTime.Parse(parts[0]);

            if (parts[3] != "")
            {
                entry._lastEdit = DateTime.Parse(parts[3]);
            }
            else
            {
                entry._lastEdit = null;
            }

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded.");
    }
}