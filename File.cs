using System.IO;
using System.Collections.Generic;

public class File
{
    public string _fileName;

    // Method to write journal entries to a file
    public void WriteFile(List<Entry> journal)
    {
        Console.WriteLine("What is the filename?");
        _fileName = Console.ReadLine(); // Capture the filename from the user

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // Write each journal entry to the file
            foreach (Entry entry in journal)
            {
                outputFile.WriteLine($"{entry._date} || {entry._question} || {entry._userResponse}");
            }
        }
    }

    // Method to read journal entries from a file
    public List<Entry> ReadFile()
    {
        List<Entry> journal = new List<Entry>();

        Console.WriteLine("What is the filename?");
        _fileName = Console.ReadLine(); // Capture the filename from the user

        // Read all lines from the specified file
        string[] entries = System.IO.File.ReadAllLines(_fileName);

        foreach (string entry in entries)
        {
            string[] lines = entry.Split(" || "); // Split each line into components

            // Create a new Entry object and set its properties
            Entry newEntry = new Entry
            {
                _date = lines[0],
                _question = lines[1],
                _userResponse = lines[2]
            };

            journal.Add(newEntry); // Add the entry to the journal list
        }
        return journal; // Return the list of journal entries
    }
}
