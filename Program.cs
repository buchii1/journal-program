using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        // Initialize necessary objects
        AddPrompt newPrompt = new AddPrompt();
        TerminalServices menu = new TerminalServices();
        Journal journal = new Journal();
        File newFile = new File();
        
        Console.WriteLine("Welcome to the Journal Program!");
        int prompt;

        do
        {
            // Display the menu and capture user choice
            menu.DisplayMenu();
            prompt = menu._userResponse;

            if (prompt == 1)
            {
                // Add a new question prompt
                newPrompt.AddNewPrompt();
                string addPrompt = newPrompt._prompt;
                menu._questionPrompts.Add(addPrompt);
            }
            else if (prompt == 2)
            {
               // Create a new journal entry
               Entry entry = new Entry();
               menu.DisplayRandomQuestions(); // Display a random question prompt

               if (menu._promptsRemaining)
               {
                    string answer = Console.ReadLine(); // Capture user response
                    string question = menu._question;

                    entry.SetEntry(answer, question); // Set entry details
                    journal._journal.Add(entry); // Add the entry to the journal             
               }
            }
            else if (prompt == 3)
            {
                // Display all journal entries
                journal.DisplayJournal();
            }
            else if (prompt == 4)
            {
                // Load journal entries from a file
                string file = newFile._fileName;
                List<Entry> savedEntries =  newFile.ReadFile();
                foreach (Entry entry in savedEntries)
                {
                    journal._journal.Add(entry); // Add entries to the journal
                }
            }
            else if (prompt == 5)
            {
                // Save journal entries to a file
                newFile.WriteFile(journal._journal);
                string file = newFile._fileName;
            }
            else
            {
                Console.WriteLine("See you next time!");
            }

        } while (prompt < 6); // Continue loop until the user chooses to quit
    }
}
