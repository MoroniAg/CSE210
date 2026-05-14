public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What is something new you learned today?");
        _prompts.Add("Describe a challenge you faced today and how you overcame it.");
        _prompts.Add("What made you smile today?");
        _prompts.Add("What is a goal you have for tomorrow?");
        _prompts.Add("What is something you wish you had done differently today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}