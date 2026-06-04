class ReflextingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflextingActivity(string name, string description, int durationInSeconds, List<string> prompts, List<string> questions) : base(name, description, durationInSeconds)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartMessage();
        base.ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine("Prompt:");
        Console.WriteLine("--- " + GetRandomPrompt() + " ---");
        Console.WriteLine();

        Console.WriteLine("Now, reflect on the following questions.  The program will show questions and pause with a spinner between each one.");
        Console.WriteLine("Press Enter when you are ready to begin reflecting on the questions.");
        Console.ReadLine();
        Console.Write("We start in ");
        base.ShowCountdown(5);


        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        Random rand = new Random();

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine();
            Console.WriteLine("* " + question);

            ShowSpinner(3);

            Console.WriteLine();
        }

        DisplayEndMessage();
        ShowSpinner(10);
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Prompt: {GetRandomPrompt()}");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"Question: {GetRandomQuestion()}");
    }


}