class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int count, int durationInSeconds, List<string> prompts) : base(name, description, durationInSeconds)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartMessage();
        base.ShowSpinner(2);

        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();
        base.ShowSpinner(2);
        Console.WriteLine("You will have a few seconds to think before you begin listing.");
        base.ShowCountdown(5);

        Console.WriteLine("Start listing! Type each item and press Enter. The activity will end when time is up.");

        List<string> entries = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("* ");
            string line = Console.ReadLine();
            entries.Add(line);
        }
        Console.WriteLine($"You entered {entries.Count} items.");
        DisplayEndMessage();
        base.ShowSpinner(5);
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine($"Random Prompt: {_prompts[index]}");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("Please enter your responses (type 'done' to finish):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            userList.Add(input);
        }
        return userList;
    }

}