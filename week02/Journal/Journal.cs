using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Entry: {entry._entryText}\n");
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}| {entry._promptText}| {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] Lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in Lines)
        {
            Console.WriteLine(line);
            // Line will have something like this: "right now, Generic, Testing"
            string[] parts = line.Split("|");

            Entry loadedEntry = new Entry(parts[1], parts[2]);
            loadedEntry._date = parts[0];
            _entries.Add(loadedEntry);
        }
    }
}