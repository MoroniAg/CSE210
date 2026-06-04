class Activity
{
    private string _name;
    private string _description;
    private int _durationInSeconds;

    public Activity(string name, string description, int durationInSeconds)
    {
        _name = name;
        _description = description;
        _durationInSeconds = durationInSeconds;
    }


    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine($"This activity will last for {_durationInSeconds} seconds.");
        Console.WriteLine("Get ready...");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Great job completing the {_name}! in {_durationInSeconds} seconds.");
    }

    public void ShowSpinner(int durationInSeconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountdown(int durationInSeconds)
    {
        for (int i = durationInSeconds; i > 0; i--)
        {
            Console.Write(i + " ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _durationInSeconds;
    }

}