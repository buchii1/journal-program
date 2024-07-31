using System.Collections.Generic;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    // Method to display all journal entries
    public void DisplayJournal()
    {
        // Iterate through each entry in the journal and display it
        foreach (Entry entry in _journal)
        {
            entry.DisplayEntry();
        }
    }
}
