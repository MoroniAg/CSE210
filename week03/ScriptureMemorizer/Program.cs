using System;

class Program
{
    static void Main(string[] args)
    {

        // This console program is a Scripture Memorizer. It reads or manages a selected
        // scripture and displays it to the user. Each time the user presses Enter,
        // the program hides a random word from the scripture until the scripture is
        // fully hidden, helping the user practice memorization. The user may type
        // 'quit' to exit early. The program demonstrates object-oriented design via
        // `ManageScripture` and `Scripture` helper classes.

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        ManageScripture manageScripture = new ManageScripture();
        Scripture scripture = manageScripture.GetScripture();
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower().Equals("quit"))
            {
                break;
            }
            scripture.HideRandomWord();
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Congratulations! You've memorized the scripture!");
    }
}