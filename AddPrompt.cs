public class AddPrompt
{
    public string _prompt;

    // Method to add a new prompt
    public void AddNewPrompt()
    {
        Console.WriteLine("Add a new question prompt:");
        _prompt = Console.ReadLine(); // Capture user input for the new prompt
    }
}
