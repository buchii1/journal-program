using System;
using System.Collections.Generic;

public class TerminalServices
{
    public int _userResponse;
    public string _question;
    public List<string> _menu = new List<string>() {"Add Prompt", "Write", "Display", "Load", "Save", "Quit"};
    public List<string> _questionPrompts = new List<string>() {
      "Who was the most interesting person I interacted with today?",
      "What was the best part of my day?",
      "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?",
      "If I had one thing I could do over today, what would it be?"
    };
    
    // Flag to indicate if there are any prompts left
    public bool _promptsRemaining = true;

    // Method to display a random question prompt
    public void DisplayRandomQuestions()
    {
        Random genRand = new Random();
        
        if (_questionPrompts.Count != 0)
        {
            // Select a random prompt from the list
            int promptIndex = genRand.Next(_questionPrompts.Count);
            _question = _questionPrompts[promptIndex];
            Console.WriteLine(_question);

            // Remove the displayed prompt from the list
            _questionPrompts.RemoveAt(promptIndex); 
        }
        else 
        {
            Console.WriteLine("No more prompts for today. Check back later!");
            _promptsRemaining = false; // Set flag to false when there are no more prompts
        }
    }

    // Method to display the menu options
    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        for (int i = 0; i < _menu.Count; i++)
        {
            // Display each menu option with its corresponding number
            Console.WriteLine($"{i + 1}. {_menu[i]}");
        }
        Console.Write("What would you like to do? ");
        _userResponse = int.Parse(Console.ReadLine()); // Capture user input for menu choice
    }
}
