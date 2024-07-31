using System;

public class Entry
{
    public string _userResponse;
    public string _date;
    public string _question;

    // Constructor to initialize the entry date
    public Entry ()
    {
        // Get the current date and time
        DateTime now = DateTime.Now;
        _date = now.ToString("MM/dd/yyyy HH:mm tt");
    }

    // Method to set the entry details
    public void SetEntry(string userResponse, string question, string date = null)
    {
        _userResponse = userResponse;
        _question = question;
        _date = date ?? _date; // Use provided date if available, otherwise use current date
    }
    
    // Method to display the entry details
    public void DisplayEntry()
    {   
        Console.WriteLine($"Date: {_date} - Prompt: {_question}\n{_userResponse}");
        Console.WriteLine();
    }
}
