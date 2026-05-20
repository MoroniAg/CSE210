using System;

class Program
{
    static void Main(string[] args)
    {
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