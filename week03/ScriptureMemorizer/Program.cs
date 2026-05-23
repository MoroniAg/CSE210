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

        // `ManageScripture`:
        // - `ManageScripture` loads scriptures from the file `scriptures.txt`.
        // - Each line in the file should use the format: "Reference; Text".
        // - The `LoadScriptures()` method reads the file using
        //   `File.ReadAllLines`.
        // - For each line it creates a `Scripture` (and `Reference`) instance and
        //   adds it to the internal `_scriptures` list.
        // - If the file is missing or a read error occurs, an error message is
        //   printed to the console and the list may remain empty.
        // - `GetScripture()` randomly selects a `Scripture` from the list and
        //   returns it to the program for use.
        // - Put `scriptures.txt` in the program's working directory (the same
        //   folder where the compiled executable runs). In this project that is
        //   typically the project root during development, or `bin/Debug/net10.0/`
        //   (for example `bin/Debug/net10.0/`) after building and when running the
        //   compiled app.
        // - When running inside the IDE (Visual Studio / VS Code), the working
        //   directory is usually the project folder (`/workspaces/CSE210/week03/ScriptureMemorizer`).
        // - If you run the compiled executable from a different folder, either
        //   copy `scriptures.txt` there or provide a full path in `ManageScripture`.
        
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