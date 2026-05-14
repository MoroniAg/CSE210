using System;

class Program
{
    static void Main(string[] args)
    {
        // Enhancement: saves entries immediately after 
        // adding so data isn't lost if the program is closed unexpectedly. 
        // Also loads entries from file on startup.
        Journal journal = new();


        Console.WriteLine("Welcome to your journal!");

        while (true)
        {
            PromptGenerator promptGenerator = new();
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {

                Console.WriteLine($"Prompt: {promptGenerator.GetRandomPrompt()}");
                Console.Write("Your entry: ");
                string entryText = Console.ReadLine();

                Entry entry = new();
                entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                entry._promptText = promptGenerator.GetRandomPrompt();
                entry._entryText = entryText;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }
}