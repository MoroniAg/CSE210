class BreathingActivity : Activity
{


    public BreathingActivity(string name, string description, int durationInSeconds) : base(name, description, durationInSeconds)
    {
    }

    public void Run()
    {
        Console.Clear();
        base.DisplayStartMessage();
        base.ShowSpinner(2);

        for (int i = 0; i < base.GetDuration() / 6; i++)
        {

            Console.WriteLine("Breathe in...");
            base.ShowSpinner(3);
            Console.WriteLine("Breathe out...");
            base.ShowSpinner(3);

        }
        base.DisplayEndMessage();
        base.ShowSpinner(5);
    }

}